function Get-PackageVersion($package)
{
    if($package -and $package.Version)
    {
        [convert]::ToInt32($package.Version.ToString().Replace("-beta", "").Replace(".", ""), 10)
    }
    else
    {
        return 0;
    }
}

function Get-BuildProject($project)
{
    return [Microsoft.Build.Evaluation.ProjectCollection]::GlobalProjectCollection.GetLoadedProjects($project.FullName) | Select-Object -First 1
}

function ApplyProjectTransformations($project)
{
	$transformations = Get-Content "$PSScriptRoot\transformations\Project.transform.json" -Raw | ConvertFrom-Json    

	foreach($item in $transformations.items)
	{
		switch ($item.transform)
		{
			"Remove" 
			{
				$itemNode = $project.Items | Where-Object { $_.ItemType -eq $item.type -and $_.EvaluatedInclude.Split(",")[0] -eq $item.include } | Select-Object -First 1
				if($itemNode)
				{
					$project.RemoveItem($itemNode)
				}
				break
			}

			"InsertIfMissing"
			{
				$itemNode = $project.Items | Where-Object { $_.ItemType -eq $item.type -and $_.EvaluatedInclude.Split(",")[0] -eq $item.include } | Select-Object -First 1
				if($itemNode -eq $null)
				{
					$project.AddItem($item.type, $item.include)
				}
				break
			}

			"Replace"
			{
				$itemNode = $project.Items | Where-Object { $_.ItemType -eq $item.type -and $_.EvaluatedInclude.Split(",")[0] -eq $item.include } | Select-Object -First 1
				if($itemNode)
				{
					$project.RemoveItem($itemNode)
				}
				$project.AddItem($item.type, $item.include)
				break
			}
		}
	}

	foreach($import in $transformations.imports)
	{
		if($import.transform -eq "Remove")
		{
			$importNode = $project.Xml.Imports | Where-Object { $_.Project -eq $import.project } | Select-Object -First 1
			if($importNode)
			{
				$project.Xml.RemoveChild($importNode)
			}
		}
	}

	$project.Save()
}

function TransformXML($xml, $xdt, $output)
{
    Add-Type -LiteralPath "$PSScriptRoot\lib\Microsoft.Web.XmlTransform.dll"

    $xmldoc = New-Object Microsoft.Web.XmlTransform.XmlTransformableDocument
    $xmldoc.PreserveWhitespace = $true
    $xmldoc.Load($xml)

    $transf = New-Object Microsoft.Web.XmlTransform.XmlTransformation($xdt)
    if ($transf.Apply($xmldoc) -eq $false)
    {
        throw "Transformation for '$xml' FAILED!"
    }
    
    $xmldoc.Save($output)
    $xmldoc.Dispose()
}

function TransformPackagesConfig($packagesConfig)
{
	if(!(Test-Path $packagesConfig))
	{
		Write-Warning "Could not find packages.config..."
		return
	}

	$transformations = Get-Content "$PSScriptRoot\transformations\packages.json" -Raw | ConvertFrom-Json
	$packagesConfigXML = [xml](Get-Content $packagesConfig)

	foreach($item in $transformations.items) 
	{
		$packageNode = $packagesConfigXML.SelectSingleNode("/packages/package[@id='$($item.id)']")

		switch ($item.transform)
		{
			"Remove" 
			{
				if($packageNode) 
				{
					$packageNode.ParentNode.RemoveChild($packageNode)
				}
				break
			}

			"InsertIfMissing"
			{
				if($packageNode -eq $null)
				{
					
					$packageNode = $packagesConfigXML.CreateElement("package")
					$packageNode.SetAttribute("id", $item.id)
					$packageNode.SetAttribute("version", $item.version)
					$packageNode.SetAttribute("targetFramework", $item.targetFramework)
					$packagesNode = $packagesConfigXML.SelectSingleNode("/packages")
					$packagesNode.AppendChild($packageNode) | out-null
					$packagesSorted = $packagesNode.SelectNodes("package") | Sort id
					$packagesNode.RemoveAll()
					$packagesSorted | foreach { $packagesNode.AppendChild($_) | out-null } 	
				}

				break
			}

			"Replace"
			{
				if($packageNode)
				{
					$packageNode.SetAttribute("version", $item.version)
					$packageNode.SetAttribute("targetFramework", $item.targetFramework)
				}

				break
			}
		}
	}

	$packagesConfigXML.Save($packagesConfig)
}
# SIG # Begin signature block
# MIIXnAYJKoZIhvcNAQcCoIIXjTCCF4kCAQExCzAJBgUrDgMCGgUAMGkGCisGAQQB
# gjcCAQSgWzBZMDQGCisGAQQBgjcCAR4wJgIDAQAABBAfzDtgWUsITrck0sYpfvNR
# AgEAAgEAAgEAAgEAAgEAMCEwCQYFKw4DAhoFAAQUdEpc9cdN35/tQqByZdK/ox6c
# EHGgghK8MIID7jCCA1egAwIBAgIQfpPr+3zGTlnqS5p31Ab8OzANBgkqhkiG9w0B
# AQUFADCBizELMAkGA1UEBhMCWkExFTATBgNVBAgTDFdlc3Rlcm4gQ2FwZTEUMBIG
# A1UEBxMLRHVyYmFudmlsbGUxDzANBgNVBAoTBlRoYXd0ZTEdMBsGA1UECxMUVGhh
# d3RlIENlcnRpZmljYXRpb24xHzAdBgNVBAMTFlRoYXd0ZSBUaW1lc3RhbXBpbmcg
# Q0EwHhcNMTIxMjIxMDAwMDAwWhcNMjAxMjMwMjM1OTU5WjBeMQswCQYDVQQGEwJV
# UzEdMBsGA1UEChMUU3ltYW50ZWMgQ29ycG9yYXRpb24xMDAuBgNVBAMTJ1N5bWFu
# dGVjIFRpbWUgU3RhbXBpbmcgU2VydmljZXMgQ0EgLSBHMjCCASIwDQYJKoZIhvcN
# AQEBBQADggEPADCCAQoCggEBALGss0lUS5ccEgrYJXmRIlcqb9y4JsRDc2vCvy5Q
# WvsUwnaOQwElQ7Sh4kX06Ld7w3TMIte0lAAC903tv7S3RCRrzV9FO9FEzkMScxeC
# i2m0K8uZHqxyGyZNcR+xMd37UWECU6aq9UksBXhFpS+JzueZ5/6M4lc/PcaS3Er4
# ezPkeQr78HWIQZz/xQNRmarXbJ+TaYdlKYOFwmAUxMjJOxTawIHwHw103pIiq8r3
# +3R8J+b3Sht/p8OeLa6K6qbmqicWfWH3mHERvOJQoUvlXfrlDqcsn6plINPYlujI
# fKVOSET/GeJEB5IL12iEgF1qeGRFzWBGflTBE3zFefHJwXECAwEAAaOB+jCB9zAd
# BgNVHQ4EFgQUX5r1blzMzHSa1N197z/b7EyALt0wMgYIKwYBBQUHAQEEJjAkMCIG
# CCsGAQUFBzABhhZodHRwOi8vb2NzcC50aGF3dGUuY29tMBIGA1UdEwEB/wQIMAYB
# Af8CAQAwPwYDVR0fBDgwNjA0oDKgMIYuaHR0cDovL2NybC50aGF3dGUuY29tL1Ro
# YXd0ZVRpbWVzdGFtcGluZ0NBLmNybDATBgNVHSUEDDAKBggrBgEFBQcDCDAOBgNV
# HQ8BAf8EBAMCAQYwKAYDVR0RBCEwH6QdMBsxGTAXBgNVBAMTEFRpbWVTdGFtcC0y
# MDQ4LTEwDQYJKoZIhvcNAQEFBQADgYEAAwmbj3nvf1kwqu9otfrjCR27T4IGXTdf
# plKfFo3qHJIJRG71betYfDDo+WmNI3MLEm9Hqa45EfgqsZuwGsOO61mWAK3ODE2y
# 0DGmCFwqevzieh1XTKhlGOl5QGIllm7HxzdqgyEIjkHq3dlXPx13SYcqFgZepjhq
# IhKjURmDfrYwggSjMIIDi6ADAgECAhAOz/Q4yP6/NW4E2GqYGxpQMA0GCSqGSIb3
# DQEBBQUAMF4xCzAJBgNVBAYTAlVTMR0wGwYDVQQKExRTeW1hbnRlYyBDb3Jwb3Jh
# dGlvbjEwMC4GA1UEAxMnU3ltYW50ZWMgVGltZSBTdGFtcGluZyBTZXJ2aWNlcyBD
# QSAtIEcyMB4XDTEyMTAxODAwMDAwMFoXDTIwMTIyOTIzNTk1OVowYjELMAkGA1UE
# BhMCVVMxHTAbBgNVBAoTFFN5bWFudGVjIENvcnBvcmF0aW9uMTQwMgYDVQQDEytT
# eW1hbnRlYyBUaW1lIFN0YW1waW5nIFNlcnZpY2VzIFNpZ25lciAtIEc0MIIBIjAN
# BgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAomMLOUS4uyOnREm7Dv+h8GEKU5Ow
# mNutLA9KxW7/hjxTVQ8VzgQ/K/2plpbZvmF5C1vJTIZ25eBDSyKV7sIrQ8Gf2Gi0
# jkBP7oU4uRHFI/JkWPAVMm9OV6GuiKQC1yoezUvh3WPVF4kyW7BemVqonShQDhfu
# ltthO0VRHc8SVguSR/yrrvZmPUescHLnkudfzRC5xINklBm9JYDh6NIipdC6Anqh
# d5NbZcPuF3S8QYYq3AhMjJKMkS2ed0QfaNaodHfbDlsyi1aLM73ZY8hJnTrFxeoz
# C9Lxoxv0i77Zs1eLO94Ep3oisiSuLsdwxb5OgyYI+wu9qU+ZCOEQKHKqzQIDAQAB
# o4IBVzCCAVMwDAYDVR0TAQH/BAIwADAWBgNVHSUBAf8EDDAKBggrBgEFBQcDCDAO
# BgNVHQ8BAf8EBAMCB4AwcwYIKwYBBQUHAQEEZzBlMCoGCCsGAQUFBzABhh5odHRw
# Oi8vdHMtb2NzcC53cy5zeW1hbnRlYy5jb20wNwYIKwYBBQUHMAKGK2h0dHA6Ly90
# cy1haWEud3Muc3ltYW50ZWMuY29tL3Rzcy1jYS1nMi5jZXIwPAYDVR0fBDUwMzAx
# oC+gLYYraHR0cDovL3RzLWNybC53cy5zeW1hbnRlYy5jb20vdHNzLWNhLWcyLmNy
# bDAoBgNVHREEITAfpB0wGzEZMBcGA1UEAxMQVGltZVN0YW1wLTIwNDgtMjAdBgNV
# HQ4EFgQURsZpow5KFB7VTNpSYxc/Xja8DeYwHwYDVR0jBBgwFoAUX5r1blzMzHSa
# 1N197z/b7EyALt0wDQYJKoZIhvcNAQEFBQADggEBAHg7tJEqAEzwj2IwN3ijhCcH
# bxiy3iXcoNSUA6qGTiWfmkADHN3O43nLIWgG2rYytG2/9CwmYzPkSWRtDebDZw73
# BaQ1bHyJFsbpst+y6d0gxnEPzZV03LZc3r03H0N45ni1zSgEIKOq8UvEiCmRDoDR
# EfzdXHZuT14ORUZBbg2w6jiasTraCXEQ/Bx5tIB7rGn0/Zy2DBYr8X9bCT2bW+IW
# yhOBbQAuOA2oKY8s4bL0WqkBrxWcLC9JG9siu8P+eJRRw4axgohd8D20UaF5Mysu
# e7ncIAkTcetqGVvP6KUwVyyJST+5z3/Jvz4iaGNTmr1pdKzFHTx/kuDDvBzYBHUw
# ggTUMIIDvKADAgECAhB5ded51rMwoW/To4csnLVUMA0GCSqGSIb3DQEBCwUAMIGE
# MQswCQYDVQQGEwJVUzEdMBsGA1UEChMUU3ltYW50ZWMgQ29ycG9yYXRpb24xHzAd
# BgNVBAsTFlN5bWFudGVjIFRydXN0IE5ldHdvcmsxNTAzBgNVBAMTLFN5bWFudGVj
# IENsYXNzIDMgU0hBMjU2IENvZGUgU2lnbmluZyBDQSAtIEcyMB4XDTE4MDUwMzAw
# MDAwMFoXDTE4MTIyMjIzNTk1OVowZjELMAkGA1UEBhMCQkcxDjAMBgNVBAgMBVNv
# ZmlhMQ4wDAYDVQQHDAVTb2ZpYTEUMBIGA1UECgwLVEVMRVJJSyBFQUQxCzAJBgNV
# BAsMAklUMRQwEgYDVQQDDAtURUxFUklLIEVBRDCCASIwDQYJKoZIhvcNAQEBBQAD
# ggEPADCCAQoCggEBAOWW+Tp+4PgZN9CyAjElsN0psKK+dLDO0FqELfgwXcIE1axv
# WgtCLSQ/1rN8WIxC8Tfu3fFNcqccOsNjP22pKgBsVF1iwzQjIQ895376gZSjvlLo
# UMV3WTV8xcvwPP7VFPmMJ8xYd5LjcKXHqaXSNM4yqSUSRjJ9PJD3QJoReOr+AGXM
# n7xKJNXVvcRJ05hqnTSZ1qZCYoS/0t3PfWXyOJ8S2u1DnGr8dvcEU/uFYpe/k/YV
# HnPQZ6JwO8GtB8pTJLTNRL/aN/QYHVhfXT5CMX/8q2+QdAXaj7mYNpfr3r+pIVTF
# UI/8mmGIXBIicNYHADVvaFT7N93W4TWmNBXHHVECAwEAAaOCAV0wggFZMAkGA1Ud
# EwQCMAAwDgYDVR0PAQH/BAQDAgeAMCsGA1UdHwQkMCIwIKAeoByGGmh0dHA6Ly9y
# Yi5zeW1jYi5jb20vcmIuY3JsMGEGA1UdIARaMFgwVgYGZ4EMAQQBMEwwIwYIKwYB
# BQUHAgEWF2h0dHBzOi8vZC5zeW1jYi5jb20vY3BzMCUGCCsGAQUFBwICMBkMF2h0
# dHBzOi8vZC5zeW1jYi5jb20vcnBhMBMGA1UdJQQMMAoGCCsGAQUFBwMDMFcGCCsG
# AQUFBwEBBEswSTAfBggrBgEFBQcwAYYTaHR0cDovL3JiLnN5bWNkLmNvbTAmBggr
# BgEFBQcwAoYaaHR0cDovL3JiLnN5bWNiLmNvbS9yYi5jcnQwHwYDVR0jBBgwFoAU
# 1MAGIknrOUvdk+JcobhHdglyA1gwHQYDVR0OBBYEFKjafrVTZQvLodzhkK2E2QF/
# G94SMA0GCSqGSIb3DQEBCwUAA4IBAQAVjO76Huz5G/CPBMbLrnnZz+BmT+Ht9NO+
# lqlcJkKDsp01L8bAcPyXXGXRlHv1FFVrRttxB82YqKXFad/lgPosyNDRkBu8pyP6
# uRqBHnSMZYM/gUJ1Z/ac+I83cgwIHxqlLauydqslevXjl96a0yOTyAnFNH1iKFtW
# RcFMQKZKcFgiGx6oul9mAnFfzUhJkn36GQqSmUBwZ+CwAUJrxj08P0cHNnfZdHE+
# JKXlk2VgqR6l1x4//aLo557b0K1lBc6PtjvQ5AmRVUu9TsQiCLMi/8FHckLbhY8h
# XFMEgd1zJpgW6n9SiVY641qqIIFTsZg4k+CTDL5akMEMeOmpsxNvMIIFRzCCBC+g
# AwIBAgIQfBs1NUrn23TnQV8RacprqDANBgkqhkiG9w0BAQsFADCBvTELMAkGA1UE
# BhMCVVMxFzAVBgNVBAoTDlZlcmlTaWduLCBJbmMuMR8wHQYDVQQLExZWZXJpU2ln
# biBUcnVzdCBOZXR3b3JrMTowOAYDVQQLEzEoYykgMjAwOCBWZXJpU2lnbiwgSW5j
# LiAtIEZvciBhdXRob3JpemVkIHVzZSBvbmx5MTgwNgYDVQQDEy9WZXJpU2lnbiBV
# bml2ZXJzYWwgUm9vdCBDZXJ0aWZpY2F0aW9uIEF1dGhvcml0eTAeFw0xNDA3MjIw
# MDAwMDBaFw0yNDA3MjEyMzU5NTlaMIGEMQswCQYDVQQGEwJVUzEdMBsGA1UEChMU
# U3ltYW50ZWMgQ29ycG9yYXRpb24xHzAdBgNVBAsTFlN5bWFudGVjIFRydXN0IE5l
# dHdvcmsxNTAzBgNVBAMTLFN5bWFudGVjIENsYXNzIDMgU0hBMjU2IENvZGUgU2ln
# bmluZyBDQSAtIEcyMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEA15VD
# 1NzfZ645+1KktiYxBHDpt45bKro3aTWVj7vAMOeG2HO73+vRdj+KVo7rLUvwVxhO
# sY2lM9MLdSPVankn3aPT9w6HZbXerRzx9TW0IlGvIqHBXUuQf8BZTqudeakC1x5J
# sTtNh/7CeKu/71KunK8I2TnlmlE+aV8wEE5xY2xY4fAgMxsPdL5byxLh24zEgJRy
# u/ZFmp7BJQv7oxye2KYJcHHswEdMj33D3hnOPu4Eco4X0//wsgUyGUzTsByf/qV4
# IEJwQbAmjG8AyDoAEUF6QbCnipEEoJl49He082Aq5mxQBLcUYP8NUfSoi4T+Idpc
# Xn31KXlPsER0b21y/wIDAQABo4IBeDCCAXQwLgYIKwYBBQUHAQEEIjAgMB4GCCsG
# AQUFBzABhhJodHRwOi8vcy5zeW1jZC5jb20wEgYDVR0TAQH/BAgwBgEB/wIBADBm
# BgNVHSAEXzBdMFsGC2CGSAGG+EUBBxcDMEwwIwYIKwYBBQUHAgEWF2h0dHBzOi8v
# ZC5zeW1jYi5jb20vY3BzMCUGCCsGAQUFBwICMBkaF2h0dHBzOi8vZC5zeW1jYi5j
# b20vcnBhMDYGA1UdHwQvMC0wK6ApoCeGJWh0dHA6Ly9zLnN5bWNiLmNvbS91bml2
# ZXJzYWwtcm9vdC5jcmwwEwYDVR0lBAwwCgYIKwYBBQUHAwMwDgYDVR0PAQH/BAQD
# AgEGMCkGA1UdEQQiMCCkHjAcMRowGAYDVQQDExFTeW1hbnRlY1BLSS0xLTcyNDAd
# BgNVHQ4EFgQU1MAGIknrOUvdk+JcobhHdglyA1gwHwYDVR0jBBgwFoAUtnf6aUhH
# n1MS1cLqBzJ2B9GXBxkwDQYJKoZIhvcNAQELBQADggEBAH/ryqfqi3ZC6z6OIFQw
# 47e53PpIPhbHD0WVEM0nhqNm8wLtcfiqwlWXkXCD+VJ+Umk8yfHglEaAGLuh1KRW
# pvMdAJHVhvNIh+DLxDRoIF60y/kF7ZyvcFMnueg+flGgaXGL3FHtgDolMp9Er25D
# KNMhdbuX2IuLjP6pBEYEhfcVnEsRjcQsF/7Vbn+a4laS8ZazrS359N/aiZnOsjhE
# wPdHe8olufoqaDObUHLeqJ/UzSwLNL2LMHhA4I2OJxuQbxq+CBWBXesv4lHnUR7J
# eCnnHmW/OO8BSgEJJA4WxBR5wUE3NNA9kVKUneFo7wjw4mmcZ26QCxqTcdQmAsPA
# WiMxggRKMIIERgIBATCBmTCBhDELMAkGA1UEBhMCVVMxHTAbBgNVBAoTFFN5bWFu
# dGVjIENvcnBvcmF0aW9uMR8wHQYDVQQLExZTeW1hbnRlYyBUcnVzdCBOZXR3b3Jr
# MTUwMwYDVQQDEyxTeW1hbnRlYyBDbGFzcyAzIFNIQTI1NiBDb2RlIFNpZ25pbmcg
# Q0EgLSBHMgIQeXXnedazMKFv06OHLJy1VDAJBgUrDgMCGgUAoHgwGAYKKwYBBAGC
# NwIBDDEKMAigAoAAoQKAADAZBgkqhkiG9w0BCQMxDAYKKwYBBAGCNwIBBDAcBgor
# BgEEAYI3AgELMQ4wDAYKKwYBBAGCNwIBFTAjBgkqhkiG9w0BCQQxFgQULFTw61+d
# boxU91/Vd/FQdefwS0UwDQYJKoZIhvcNAQEBBQAEggEAl9amk0hiWe9xE6ejpMNR
# Crs2mLD9sSpWgyeyRSPVAESuIAGjDR5MXni8urLrSG6KD4BYwKGC+p+HEbbYbH3z
# W628FcmEM1AnEmgSJuLFaYDGKVgIIu+wUKUGYCpj/alvr5l8Uimt2ZsvUU3oKzzU
# eSCQY96iW39T7GDUoZu7cIinQZBwhpTrUN42pQ3bv8Wr8ftazWg6tUv65N45Lsvx
# EZcRfW5NZP3JUMSU0b9oP1HveRu4uVXB8Ueg6j0zpWqKzfqxmdSPKVNhBoIFd/GE
# JNsD8x75AIEroInxpuoKgtusatTIqNbF2706hHFmOLbhfVH8NHkW9sOZQTIsdB1G
# KaGCAgswggIHBgkqhkiG9w0BCQYxggH4MIIB9AIBATByMF4xCzAJBgNVBAYTAlVT
# MR0wGwYDVQQKExRTeW1hbnRlYyBDb3Jwb3JhdGlvbjEwMC4GA1UEAxMnU3ltYW50
# ZWMgVGltZSBTdGFtcGluZyBTZXJ2aWNlcyBDQSAtIEcyAhAOz/Q4yP6/NW4E2GqY
# GxpQMAkGBSsOAwIaBQCgXTAYBgkqhkiG9w0BCQMxCwYJKoZIhvcNAQcBMBwGCSqG
# SIb3DQEJBTEPFw0xODEwMDExMjA3MjJaMCMGCSqGSIb3DQEJBDEWBBSD1F3VQmhn
# dUCxdoDvHzLyNuR9ADANBgkqhkiG9w0BAQEFAASCAQCKpJMsfqQ1mgY2Urutt+RO
# eNQ9FeGpMZs6Lj8tLffF8agxA2UK28yGkwhMbNBAaqFcBB8aK/9Og26B8N4rKOr9
# naqyCci8IWfNHx3CEW7MzUdVW8ufCozikuZkKP72EPPTndFeDU6kERDVCUOEUBik
# HvSchGGyPmQKQDWw9t9Cb89NM8zzCL70htIkB33GPSSEcLOnVWYkLQ45gDcWrtcu
# 23Po/CtGdEMht4r/U1z+JxAxVXlm5GL5aUQuMimHGq4UIEO1KJOs9e2HEmXKztgq
# LZRj2XQYxoRiS/v9RyynXtTFzw1KagfGR8Oi2qYjgTD7P0ztix/bopzT6qmUG0Na
# SIG # End signature block
