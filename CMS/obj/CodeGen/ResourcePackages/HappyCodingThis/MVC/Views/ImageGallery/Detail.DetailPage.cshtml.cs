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

namespace SitefinityWebApp.ResourcePackages.HappyCodingThis.MVC.Views.ImageGallery
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
    
    #line 3 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
    using Telerik.Sitefinity.Web.DataResolving;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/HappyCodingThis/MVC/Views/ImageGallery/Detail.DetailPage.cshtm" +
        "l")]
    public partial class Detail_DetailPage : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Media.Mvc.Models.ImageGallery.ImageDetailsViewModel>
    {
        public Detail_DetailPage()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 266), Tuple.Create("\"", 289)
            
            #line 8 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 274), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 274), false)
);

WriteLiteral(" ");

            
            #line 8 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                        Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)Model.Item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\n    <h2>\n        <span ");

            
            #line 10 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
         Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 10 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                                                                  Write(Model.Item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\n    </h2>\n\n    <span");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\n");

WriteLiteral("        ");

            
            #line 14 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
   Write(Model.Item.GetDateTime("PublicationDate", "MMM d, yyyy, HH:mm tt"));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("        ");

            
            #line 15 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
   Write(Html.Resource("By"));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("        ");

            
            #line 16 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
   Write(DataResolver.Resolve(@Model.Item.DataItem, "Author", null));

            
            #line default
            #line hidden
WriteLiteral("\n    </span>\n");

WriteLiteral("    ");

            
            #line 18 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
Write(Html.CommentsCount(string.Empty, @Model.Item.DataItem));

            
            #line default
            #line hidden
WriteLiteral("\n\n    <div ");

            
            #line 20 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
    Write(Html.InlineEditingFieldAttributes("Description", "LongText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 20 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                                                                  Write(Html.Raw(Model.Item.Fields.Description));

            
            #line default
            #line hidden
WriteLiteral("</div>\n\n    <img");

WriteAttribute("src", Tuple.Create(" src=\"", 924), Tuple.Create("\"", 955)
            
            #line 22 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 930), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.MediaUrl)
            
            #line default
            #line hidden
, 930), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\'", 956), Tuple.Create("\'", 1060)
            
            #line 22 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 962), Tuple.Create<System.Object, System.Int32>(System.Text.RegularExpressions.Regex.Replace(Model.Item.Fields.AlternativeText, @"[^\w\d_-]", "")
            
            #line default
            #line hidden
, 962), false)
);

WriteLiteral("\n                 ");

            
            #line 23 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
            Write(Html.GetWidthAttributeIfExists(Model.Width));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                 ");

            
            #line 24 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
            Write(Html.GetHeightAttributeIfExists(Model.Height));

            
            #line default
            #line hidden
WriteLiteral(" />\n\n");

            
            #line 26 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
    
            
            #line default
            #line hidden
            
            #line 26 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
     if (ViewBag.ItemIndex != null)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"m-bottom-lg text-center\"");

WriteLiteral(">\n");

            
            #line 29 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
            
            
            #line default
            #line hidden
            
            #line 29 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
              
                var previousItemIndex = ViewBag.ItemIndex == 1 ? Model.TotalItemsCount : ViewBag.ItemIndex - 1;
                var nextItemIndex = ViewBag.ItemIndex == Model.TotalItemsCount ? 1 : ViewBag.ItemIndex + 1;
            
            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 34 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
            
            
            #line default
            #line hidden
            
            #line 34 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
             if (Model.PreviousItem != null) 
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteLiteral(" class=\"pull-left\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1626), Tuple.Create("\"", 1775)
            
            #line 36 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 1633), Tuple.Create<System.Object, System.Int32>(HyperLinkHelpers.GetDetailPageUrl(Model.PreviousItem, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, ViewBag.UrlKeyPrefix, previousItemIndex)
            
            #line default
            #line hidden
, 1633), false)
);

WriteLiteral(">\n");

WriteLiteral("                    ");

            
            #line 37 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
               Write(Html.Resource("PreviousImage"));

            
            #line default
            #line hidden
WriteLiteral("\n                </a>\n");

            
            #line 39 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 41 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
            
            
            #line default
            #line hidden
            
            #line 41 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
             if (Model.PreviousItem != null || @Model.NextItem != null)
            {
                string.Format(@Html.Resource("IndexOfTotal"), @ViewBag.ItemIndex, @Model.TotalItemsCount);
            }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 46 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
            
            
            #line default
            #line hidden
            
            #line 46 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
             if (Model.NextItem != null) 
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteLiteral(" class=\"pull-right\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2167), Tuple.Create("\"", 2308)
            
            #line 48 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 2174), Tuple.Create<System.Object, System.Int32>(HyperLinkHelpers.GetDetailPageUrl(Model.NextItem, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, ViewBag.UrlKeyPrefix, nextItemIndex)
            
            #line default
            #line hidden
, 2174), false)
);

WriteLiteral(">\n");

WriteLiteral("                    ");

            
            #line 49 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
               Write(Html.Resource("NextImage"));

            
            #line default
            #line hidden
WriteLiteral("\n                </a>\n");

            
            #line 51 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\n");

            
            #line 53 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"

        
            
            #line default
            #line hidden
            
            #line 54 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
   Write(Html.ActionLink(Html.Resource("BackToAllImages"), "Index"));

            
            #line default
            #line hidden
            
            #line 54 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                                                                   
    }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 57 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
    
            
            #line default
            #line hidden
            
            #line 57 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
              
        if (Model.EnableSocialSharing)
        {
            var item = Model.Item.DataItem as Telerik.Sitefinity.Model.IHasTitle;
            
            
            #line default
            #line hidden
            
            #line 61 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
       Write(Html.SocialShareOptions(item));

            
            #line default
            #line hidden
            
            #line 61 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                                          ;
        }
    
            
            #line default
            #line hidden
WriteLiteral("\n\n");

WriteLiteral("    ");

            
            #line 65 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
Write(Html.CommentsList(@Model.Item.DataItem));

            
            #line default
            #line hidden
WriteLiteral("\n\n</div>");

        }
    }
}
#pragma warning restore 1591
