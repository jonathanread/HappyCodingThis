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

namespace SitefinityWebApp.ResourcePackages.HappyCodingThis.MVC.Views.DocumentsList
{
    
    #line 3 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
    using System;
    
    #line default
    #line hidden
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
    
    #line 5 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Models.DocumentsList;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/HappyCodingThis/MVC/Views/DocumentsList/List.DocumentsList.csh" +
        "tml")]
    public partial class List_DocumentsList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Media.Mvc.Models.DocumentsList.DocumentsListViewModel>
    {
        public List_DocumentsList()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 225), Tuple.Create("\"", 248)
            
            #line 7 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
, Tuple.Create(Tuple.Create("", 233), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 233), false)
);

WriteLiteral(">\n\n");

            
            #line 9 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
		
            
            #line default
            #line hidden
            
            #line 9 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
         foreach (var item in Model.Items)
		{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t<div");

WriteLiteral(" class=\"media\"");

WriteLiteral(">\n\t\t\t\t<div");

WriteLiteral(" class=\"media-left\"");

WriteLiteral(">\n\t\t\t\t\t<i");

WriteLiteral(" class=\"icon-file icon-txt icon-md\"");

WriteLiteral(">\n\t\t\t\t\t\t<span");

WriteAttribute("class", Tuple.Create(" class=\"", 400), Tuple.Create("\"", 459)
, Tuple.Create(Tuple.Create("", 408), Tuple.Create("icon-txt-", 408), true)
            
            #line 14 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
, Tuple.Create(Tuple.Create("", 417), Tuple.Create<System.Object, System.Int32>(((DocumentItemViewModel)item).Extension
            
            #line default
            #line hidden
, 417), false)
);

WriteLiteral(">");

            
            #line 14 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
                                                                                      Write(((DocumentItemViewModel)item).Extension);

            
            #line default
            #line hidden
WriteLiteral("</span>\n\t\t\t\t\t</i>\n\t\t\t\t</div>\n\t\t\t\t<div");

WriteLiteral(" class=\"media-body\"");

WriteLiteral(">\n\t\t\t\t\t<a");

WriteAttribute("href", Tuple.Create(" href=\"", 568), Tuple.Create("\"", 682)
            
            #line 18 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
, Tuple.Create(Tuple.Create("", 575), Tuple.Create<System.Object, System.Int32>(HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix)
            
            #line default
            #line hidden
, 575), false)
);

WriteLiteral(">\n\t\t\t\t\t\t\t<strong>");

            
            #line 19 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
                               Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</strong>\n\t\t\t\t\t</a>\n\t\t\t\t\t<span");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">(");

            
            #line 21 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
                                          Write(((DocumentItemViewModel)item).Extension);

            
            #line default
            #line hidden
WriteLiteral(")</span>\n\n\t\t\t\t\t<div>\n\t\t\t\t\t\t<a");

WriteAttribute("href", Tuple.Create(" href=\"", 840), Tuple.Create("\"", 868)
            
            #line 24 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
, Tuple.Create(Tuple.Create("", 847), Tuple.Create<System.Object, System.Int32>(item.Fields.MediaUrl
            
            #line default
            #line hidden
, 847), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">Download</a>\n\t\t\t\t\t\t<span");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">(");

            
            #line 25 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
                                              Write(Math.Ceiling((double)item.Fields.TotalSize / 1024) + " KB");

            
            #line default
            #line hidden
WriteLiteral(")</span>\n\t\t\t\t\t</div>\n\t\t\t\t</div>\n\t\t\t</div>\n");

            
            #line 29 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
		}

            
            #line default
            #line hidden
WriteLiteral("\n</div>\n\n");

            
            #line 33 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
 if (Model.ShowPager)
{
		
            
            #line default
            #line hidden
            
            #line 35 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
   Write(Html.Action("Index", "ContentPager", new
			 {
					 currentPage = Model.CurrentPage,
					 totalPagesCount = Model.TotalPagesCount.Value,
					 redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
			 }));

            
            #line default
            #line hidden
            
            #line 40 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
               
}

            
            #line default
            #line hidden
WriteLiteral("\n\n");

        }
    }
}
#pragma warning restore 1591
