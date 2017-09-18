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

namespace SitefinityWebApp.ResourcePackages.HappyCodingThis.MVC.Views.SocialShare
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
    
    #line 3 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 2 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
    using Telerik.Sitefinity.Frontend.SocialShare.SocialShareHelpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/HappyCodingThis/MVC/Views/SocialShare/SocialShare.cshtml")]
    public partial class SocialShare : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.SocialShare.Mvc.Models.SocialShareModel>
    {
        public SocialShare()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 6 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
  
    var shareUrl = SocialShareButtons.ShareUrl;
    var unencodedPageTitle = Model.ItemTitle != null ? Model.ItemTitle : SocialShareButtons.PageTitle;
    var pageTitle = HttpUtility.UrlEncode(unencodedPageTitle);

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 12 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
Write(Html.StyleSheet(Url.WidgetContent("assets/dist/css/sf-social-share.min.css"), "head", false));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 13 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
Write(Html.Script(ScriptRef.JQuery, "head", false));

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 595), Tuple.Create("\"", 618)
            
            #line 15 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
, Tuple.Create(Tuple.Create("", 603), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 603), false)
);

WriteLiteral(">\n    <ul");

WriteLiteral(" class=\"list-inline sf-social-share\"");

WriteLiteral(">\n");

            
            #line 17 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
        
            
            #line default
            #line hidden
            
            #line 17 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
         foreach (var button in Model.SocialButtons)
        {
            switch (button.ButtonName)
            {
                case "Facebook":

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 22 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                                                                 Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\n                <a");

WriteLiteral(" href=\"#\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 933), Tuple.Create("\"", 1145)
, Tuple.Create(Tuple.Create("", 943), Tuple.Create("window.open(\'https://www.facebook.com/sharer/sharer.php?app_id=309437425817038&am" +
"p;sdk=joey&amp;u=", 943), true)
            
            #line 23 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                                                       , Tuple.Create(Tuple.Create("", 1041), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 1041), false)
, Tuple.Create(Tuple.Create("", 1050), Tuple.Create("&amp;display=popup&amp;ref=plugin\',", 1050), true)
, Tuple.Create(Tuple.Create(" ", 1085), Tuple.Create("\'Facebook\',\'toolbar=no,width=550,height=180\');", 1086), true)
, Tuple.Create(Tuple.Create(" ", 1132), Tuple.Create("return", 1133), true)
, Tuple.Create(Tuple.Create(" ", 1139), Tuple.Create("false", 1140), true)
);

WriteLiteral(">\n                    <span");

WriteLiteral(" class=\"sf-icon-facebook\"");

WriteLiteral("></span>\n                </a>\n            </li>\n");

            
            #line 27 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                    break;
                case "Twitter":

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 29 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                                                                 Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\n                <a");

WriteLiteral(" href=\"#\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 1423), Tuple.Create("\"", 1546)
, Tuple.Create(Tuple.Create("", 1433), Tuple.Create("window.open(\'http://twitter.com/share?url=", 1433), true)
            
            #line 30 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
, Tuple.Create(Tuple.Create("", 1475), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 1475), false)
, Tuple.Create(Tuple.Create("", 1484), Tuple.Create("\',", 1484), true)
, Tuple.Create(Tuple.Create(" ", 1486), Tuple.Create("\'Twitter\',", 1487), true)
, Tuple.Create(Tuple.Create(" ", 1497), Tuple.Create("\'toolbar=no,width=550,height=450\');", 1498), true)
, Tuple.Create(Tuple.Create(" ", 1533), Tuple.Create("return", 1534), true)
, Tuple.Create(Tuple.Create(" ", 1540), Tuple.Create("false", 1541), true)
);

WriteLiteral(" ><span");

WriteLiteral(" class=\"sf-icon-twitter\"");

WriteLiteral("></span></a>\n            </li>\n");

            
            #line 32 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                    break;
                case "LinkedIn":

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 34 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                                                                 Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\n                <a");

WriteLiteral(" href=\"#\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 1787), Tuple.Create("\"", 1975)
, Tuple.Create(Tuple.Create("", 1797), Tuple.Create("window.open(\'http://www.linkedin.com/shareArticle?mini=true&amp;url=", 1797), true)
            
            #line 35 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                         , Tuple.Create(Tuple.Create("", 1865), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 1865), false)
, Tuple.Create(Tuple.Create("", 1874), Tuple.Create("&amp;title=", 1874), true)
            
            #line 35 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                                             , Tuple.Create(Tuple.Create("", 1885), Tuple.Create<System.Object, System.Int32>(pageTitle
            
            #line default
            #line hidden
, 1885), false)
, Tuple.Create(Tuple.Create("", 1895), Tuple.Create("\',", 1895), true)
, Tuple.Create(Tuple.Create(" ", 1897), Tuple.Create("\'LinkedIn\',", 1898), true)
, Tuple.Create(Tuple.Create(" ", 1909), Tuple.Create("\'toolbar=no,width=550,height=450\',", 1910), true)
, Tuple.Create(Tuple.Create(" ", 1944), Tuple.Create("\'yes\',", 1945), true)
, Tuple.Create(Tuple.Create(" ", 1951), Tuple.Create("\'center\');", 1952), true)
, Tuple.Create(Tuple.Create(" ", 1962), Tuple.Create("return", 1963), true)
, Tuple.Create(Tuple.Create(" ", 1969), Tuple.Create("false", 1970), true)
);

WriteLiteral(">\n                    <span");

WriteLiteral(" class=\"sf-icon-linkedin\"");

WriteLiteral("></span>\n                </a>\n            </li>\n");

            
            #line 39 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                    break;
                case "GooglePlusOne":

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 41 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                                                                 Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\n\t\t\t<div");

WriteLiteral(" class=\'g-plusone\'");

WriteLiteral(" data-size=\'small\'");

WriteLiteral(" data-annotation=\'none\'");

WriteLiteral(" data-callback=\"googleShareCallback\"");

WriteLiteral("></div>\n\t\t\t<script");

WriteLiteral(" type=\'text/javascript\'");

WriteLiteral(@">
				(function () { var po = document.createElement('script'); po.type = 'text/javascript'; po.async = true; po.src = 'https://apis.google.com/js/platform.js'; var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(po, s); })();
			</script>
            </li>
");

            
            #line 47 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                    break;
                case "Blogger":

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 49 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                                                                 Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\n                <a");

WriteLiteral(" href=\"#\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 2836), Tuple.Create("\"", 2980)
, Tuple.Create(Tuple.Create("", 2846), Tuple.Create("window.open(\'https://www.blogger.com/blogger.g?t&u=", 2846), true)
            
            #line 50 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
        , Tuple.Create(Tuple.Create("", 2897), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 2897), false)
, Tuple.Create(Tuple.Create("", 2906), Tuple.Create("&n=", 2906), true)
            
            #line 50 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                    , Tuple.Create(Tuple.Create("", 2909), Tuple.Create<System.Object, System.Int32>(pageTitle
            
            #line default
            #line hidden
, 2909), false)
, Tuple.Create(Tuple.Create("", 2919), Tuple.Create("\',", 2919), true)
, Tuple.Create(Tuple.Create(" ", 2921), Tuple.Create("\'Blogger\',\'toolbar=no,width=550,height=550\');", 2922), true)
, Tuple.Create(Tuple.Create(" ", 2967), Tuple.Create("return", 2968), true)
, Tuple.Create(Tuple.Create(" ", 2974), Tuple.Create("false", 2975), true)
);

WriteLiteral(" title=\"Share on Blogger\"");

WriteLiteral(">\n                    <span");

WriteLiteral(" class=\"sf-icon-blogger\"");

WriteLiteral("></span>\n                </a>\n            </li>\n");

            
            #line 54 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                    break;
                case "Delicious":

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 56 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                                                                 Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\n                <a");

WriteLiteral(" href=\"#\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 3284), Tuple.Create("\"", 3452)
, Tuple.Create(Tuple.Create("", 3294), Tuple.Create("window.open(\'https://delicious.com/save?v=5&noui&jump=close&url=", 3294), true)
            
            #line 57 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                     , Tuple.Create(Tuple.Create("", 3358), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 3358), false)
, Tuple.Create(Tuple.Create("", 3367), Tuple.Create("&amp;title=", 3367), true)
            
            #line 57 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                                         , Tuple.Create(Tuple.Create("", 3378), Tuple.Create<System.Object, System.Int32>(pageTitle
            
            #line default
            #line hidden
, 3378), false)
, Tuple.Create(Tuple.Create("", 3388), Tuple.Create("\',", 3388), true)
, Tuple.Create(Tuple.Create(" ", 3390), Tuple.Create("\'delicious\',\'toolbar=no,width=550,height=550\');", 3391), true)
, Tuple.Create(Tuple.Create(" ", 3438), Tuple.Create("return", 3439), true)
, Tuple.Create(Tuple.Create(" ", 3445), Tuple.Create("false;", 3446), true)
);

WriteLiteral(">\n                    <span");

WriteLiteral(" class=\"sf-icon-delicious\"");

WriteLiteral("></span>\n                </a>\n            </li>\n");

            
            #line 61 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                    break;
                case "Tumblr":

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 63 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                                                                 Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\n                <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" onclick=\"window.open(\'http://www.tumblr.com/share\', \'Tumblr\',\'toolbar=no,width=9" +
"00,height=550\')\"");

WriteLiteral(";");

WriteLiteral(" title=\"Share on Tumblr\"");

WriteLiteral(" style=\"display: inline-block; text-indent: -9999px; overflow: hidden; width: 16p" +
"x; height: 16px; background: url(\'https://platform.tumblr.com/v1/share_4.png\') t" +
"op left no-repeat transparent;\"");

WriteLiteral(">Share on Tumblr</a>\n            </li>\n");

            
            #line 66 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                    break;
                case "GoogleBookmarks":

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 68 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                                                                 Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\n                <a");

WriteLiteral(" href=\"#\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 4268), Tuple.Create("\"", 4437)
, Tuple.Create(Tuple.Create("", 4278), Tuple.Create("window.open(\'https://www.google.com/bookmarks/mark?op=add&bkmk=", 4278), true)
            
            #line 69 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                    , Tuple.Create(Tuple.Create("", 4341), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 4341), false)
, Tuple.Create(Tuple.Create("", 4350), Tuple.Create("&title=", 4350), true)
            
            #line 69 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                                    , Tuple.Create(Tuple.Create("", 4357), Tuple.Create<System.Object, System.Int32>(pageTitle
            
            #line default
            #line hidden
, 4357), false)
, Tuple.Create(Tuple.Create("", 4367), Tuple.Create("\',", 4367), true)
, Tuple.Create(Tuple.Create(" ", 4369), Tuple.Create("\'Google", 4370), true)
, Tuple.Create(Tuple.Create(" ", 4377), Tuple.Create("bookmarks\',\'toolbar=no,width=900,height=550\');", 4378), true)
, Tuple.Create(Tuple.Create(" ", 4424), Tuple.Create("return", 4425), true)
, Tuple.Create(Tuple.Create(" ", 4431), Tuple.Create("false", 4432), true)
);

WriteLiteral(" title=\"Share on GoogleBookmarks\"");

WriteLiteral(">\n                    <span");

WriteLiteral(" class=\"sf-icon-google\"");

WriteLiteral("></span>\n                </a>\n            </li>\n");

            
            #line 73 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                    break;
                case "Digg":

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 75 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                                                                 Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\n                <a");

WriteLiteral(" href=\"#\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 4743), Tuple.Create("\"", 4877)
, Tuple.Create(Tuple.Create("", 4753), Tuple.Create("window.open(\'http://digg.com/submit?url=", 4753), true)
            
            #line 76 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
, Tuple.Create(Tuple.Create("", 4793), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 4793), false)
, Tuple.Create(Tuple.Create("", 4802), Tuple.Create("&title=", 4802), true)
            
            #line 76 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
             , Tuple.Create(Tuple.Create("", 4809), Tuple.Create<System.Object, System.Int32>(pageTitle
            
            #line default
            #line hidden
, 4809), false)
, Tuple.Create(Tuple.Create("", 4819), Tuple.Create("\',", 4819), true)
, Tuple.Create(Tuple.Create(" ", 4821), Tuple.Create("\'Digg\',\'toolbar=no,width=550,height=550\');", 4822), true)
, Tuple.Create(Tuple.Create(" ", 4864), Tuple.Create("return", 4865), true)
, Tuple.Create(Tuple.Create(" ", 4871), Tuple.Create("false", 4872), true)
);

WriteLiteral(" title=\"Share on Digg\"");

WriteLiteral(">\n                    <span");

WriteLiteral(" class=\"sf-icon-digg\"");

WriteLiteral("></span>\n                </a>\n            </li>\n");

            
            #line 80 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                    break;
                case "MySpace":

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 82 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                                                                 Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\n                <a");

WriteLiteral(" href=\"#\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 5173), Tuple.Create("\"", 5323)
, Tuple.Create(Tuple.Create("", 5183), Tuple.Create("window.open(\'http://myspace.com/Modules/PostTo/Pages/?u=", 5183), true)
            
            #line 83 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
             , Tuple.Create(Tuple.Create("", 5239), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 5239), false)
, Tuple.Create(Tuple.Create("", 5248), Tuple.Create("&t=", 5248), true)
            
            #line 83 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                         , Tuple.Create(Tuple.Create("", 5251), Tuple.Create<System.Object, System.Int32>(pageTitle
            
            #line default
            #line hidden
, 5251), false)
, Tuple.Create(Tuple.Create("", 5261), Tuple.Create("\',", 5261), true)
, Tuple.Create(Tuple.Create(" ", 5263), Tuple.Create("\'My", 5264), true)
, Tuple.Create(Tuple.Create(" ", 5267), Tuple.Create("Space\',\'toolbar=no,width=550,height=550\');", 5268), true)
, Tuple.Create(Tuple.Create(" ", 5310), Tuple.Create("return", 5311), true)
, Tuple.Create(Tuple.Create(" ", 5317), Tuple.Create("false", 5318), true)
);

WriteLiteral(" title=\"Share on MySpace\"");

WriteLiteral(">\n                    <span");

WriteLiteral(" class=\"sf-icon-myspace\"");

WriteLiteral("></span>\n                </a>\n            </li>\n");

            
            #line 87 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                    break;
                case "StumbleUpon":

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 89 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                                                                 Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\n                <a");

WriteLiteral(" href=\"#\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 5629), Tuple.Create("\"", 5778)
, Tuple.Create(Tuple.Create("", 5639), Tuple.Create("window.open(\'http://stumbleupon.com/submit?url=", 5639), true)
            
            #line 90 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
    , Tuple.Create(Tuple.Create("", 5686), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 5686), false)
, Tuple.Create(Tuple.Create("", 5695), Tuple.Create("&title=", 5695), true)
            
            #line 90 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                    , Tuple.Create(Tuple.Create("", 5702), Tuple.Create<System.Object, System.Int32>(pageTitle
            
            #line default
            #line hidden
, 5702), false)
, Tuple.Create(Tuple.Create("", 5712), Tuple.Create("\',", 5712), true)
, Tuple.Create(Tuple.Create(" ", 5714), Tuple.Create("\'Stumble", 5715), true)
, Tuple.Create(Tuple.Create(" ", 5723), Tuple.Create("upon\',\'toolbar=no,width=550,height=550\');", 5724), true)
, Tuple.Create(Tuple.Create(" ", 5765), Tuple.Create("return", 5766), true)
, Tuple.Create(Tuple.Create(" ", 5772), Tuple.Create("false", 5773), true)
);

WriteLiteral(" title=\"Share on StumbleUpon\"");

WriteLiteral(">\n                    <span");

WriteLiteral(" class=\"sf-icon-stumble-upon\"");

WriteLiteral("></span>\n                </a>\n            </li>\n");

            
            #line 94 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                    break;
                case "Reddit":

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 96 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                                                                 Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\n                <a");

WriteLiteral(" href=\"#\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 6088), Tuple.Create("\"", 6242)
, Tuple.Create(Tuple.Create("", 6098), Tuple.Create("window.open(\'http://www.reddit.com/submit?newwindow=1&url=", 6098), true)
            
            #line 97 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
               , Tuple.Create(Tuple.Create("", 6156), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 6156), false)
, Tuple.Create(Tuple.Create("", 6165), Tuple.Create("&title=", 6165), true)
            
            #line 97 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                               , Tuple.Create(Tuple.Create("", 6172), Tuple.Create<System.Object, System.Int32>(pageTitle
            
            #line default
            #line hidden
, 6172), false)
, Tuple.Create(Tuple.Create("", 6182), Tuple.Create("\',", 6182), true)
, Tuple.Create(Tuple.Create(" ", 6184), Tuple.Create("\'Reddit\',\'toolbar=no,width=870,height=550\');", 6185), true)
, Tuple.Create(Tuple.Create(" ", 6229), Tuple.Create("return", 6230), true)
, Tuple.Create(Tuple.Create(" ", 6236), Tuple.Create("false", 6237), true)
);

WriteLiteral(" title=\"Share on Reddit\"");

WriteLiteral(">\n                    <span");

WriteLiteral(" class=\"sf-icon-reddit\"");

WriteLiteral("></span>\n                </a>\n            </li>\n");

            
            #line 101 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                    break;

                case "MailTo":

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" data-sf-role=\"socialShare\"");

WriteLiteral(" data-sf-socialshareoption=\"");

            
            #line 104 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                                                                 Write(button.ButtonName);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\n                <a");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 6533), Tuple.Create("\"", 6658)
, Tuple.Create(Tuple.Create("", 6543), Tuple.Create("window.open(\'mailto:?body=", 6543), true)
            
            #line 105 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
, Tuple.Create(Tuple.Create("", 6569), Tuple.Create<System.Object, System.Int32>(shareUrl
            
            #line default
            #line hidden
, 6569), false)
, Tuple.Create(Tuple.Create("", 6578), Tuple.Create("&subject=", 6578), true)
            
            #line 105 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
, Tuple.Create(Tuple.Create("", 6587), Tuple.Create<System.Object, System.Int32>(pageTitle
            
            #line default
            #line hidden
, 6587), false)
, Tuple.Create(Tuple.Create("", 6597), Tuple.Create("\',", 6597), true)
, Tuple.Create(Tuple.Create(" ", 6599), Tuple.Create("\'MailTo\',", 6600), true)
, Tuple.Create(Tuple.Create(" ", 6609), Tuple.Create("\'toolbar=no,width=550,height=550\');", 6610), true)
, Tuple.Create(Tuple.Create(" ", 6645), Tuple.Create("return", 6646), true)
, Tuple.Create(Tuple.Create(" ", 6652), Tuple.Create("false", 6653), true)
);

WriteLiteral(" title=\"Tell a friend\"");

WriteLiteral(">\n                    <span");

WriteLiteral(" class=\"sf-icon-mailto\"");

WriteLiteral("></span>\n                </a>\n            </li>\n");

            
            #line 109 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
                    break;

                default:
                    break;
            }
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\n</div>\n\n");

            
            #line 118 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\SocialShare\SocialShare.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/SocialShare/social-share.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\n");

        }
    }
}
#pragma warning restore 1591
