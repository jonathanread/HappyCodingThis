#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitefinityWebApp.ResourcePackages.HappyCodingThis.MVC.Views.UnsubscribeForm
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 3 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/UnsubscribeForm/UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml")]
    public partial class UnsubscribeFormByEmailAddress_UnsubscribeForm : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.EmailCampaigns.Mvc.Models.UnsubscribeForm.UnsubscribeFormViewModel>
    {
        public UnsubscribeFormByEmailAddress_UnsubscribeForm()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

WriteLiteral("\n");

            
            #line 9 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 10 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/jquery.validate/1.8.1/jquery.validate.js", "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 11 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/mvc/4.0/jquery.validate.unobtrusive.min.js", "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 541), Tuple.Create("\"", 564)
            
            #line 13 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
, Tuple.Create(Tuple.Create("", 549), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 549), false)
);

WriteLiteral(">    \n");

            
            #line 14 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
	
            
            #line default
            #line hidden
            
            #line 14 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
     using (Html.BeginFormSitefinity())
	{	

            
            #line default
            #line hidden
WriteLiteral("\t\t<h3>");

            
            #line 16 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
       Write(Model.WidgetTitle);

            
            #line default
            #line hidden
WriteLiteral("</h3>\n");

            
            #line 17 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
		

            
            #line default
            #line hidden
WriteLiteral("\t\t<p");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 18 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
                         Write(Model.WidgetDescription);

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 19 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
		
		if (ViewBag.IsSucceded == true)
		{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t<div");

WriteLiteral(" class=\"alert alert-success\"");

WriteLiteral(">");

            
            #line 22 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
                                        Write(Html.Raw(Model.Message));

            
            #line default
            #line hidden
WriteLiteral("</div>\n");

            
            #line 23 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
		}
		
		
            
            #line default
            #line hidden
            
            #line 25 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
   Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 25 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
                                     
		
		if (!string.IsNullOrEmpty(ViewBag.Error))
		{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t<div");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(">\n");

WriteLiteral("\t\t\t\t");

            
            #line 30 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
           Write(ViewBag.Error);

            
            #line default
            #line hidden
WriteLiteral("\n\t\t\t</div>\n");

            
            #line 32 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
		}
		

            
            #line default
            #line hidden
WriteLiteral("\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n\t\t\t<label>\n");

WriteLiteral("\t\t\t\t");

            
            #line 36 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
           Write(Html.Resource("Email"));

            
            #line default
            #line hidden
WriteLiteral("\n\t\t\t</label>\n\n\t\t\t<div");

WriteLiteral(" class=\"form-inline\"");

WriteLiteral(">\n\n");

WriteLiteral("\t\t\t\t");

            
            #line 41 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
           Write(Html.TextBoxFor(u => u.Email, new { @class = "form-control", type = "email" }));

            
            #line default
            #line hidden
WriteLiteral("\n\n\t\t\t\t<button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">");

            
            #line 43 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
                                                         Write(Html.Resource("ButtonUnsubscribe"));

            
            #line default
            #line hidden
WriteLiteral("</button>\n\t\n\t\t\t</div>\n\n");

            
            #line 47 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
			
            
            #line default
            #line hidden
            
            #line 47 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
             if (Html.ValidationMessageFor(u => u.Email) != null)
			{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t<div");

WriteLiteral(" class=\"has-error\"");

WriteLiteral(">\n\t\t\t\t\t<span");

WriteLiteral(" class=\"help-block\"");

WriteLiteral(">");

            
            #line 50 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
                                        Write(Html.ValidationMessageFor(u => u.Email));

            
            #line default
            #line hidden
WriteLiteral("</span>\n\t\t\t\t</div>\n");

            
            #line 52 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
			}

            
            #line default
            #line hidden
WriteLiteral("\n\t\t</div>\t\t\n");

            
            #line 55 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
	}

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591
