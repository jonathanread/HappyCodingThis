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

namespace SitefinityWebApp.ResourcePackages.HappyCodingThis.MVC.Views.UsersList
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
    
    #line 3 "..\..MVC\Views\UsersList\Detail.UserDetails.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 7 "..\..MVC\Views\UsersList\Detail.UserDetails.cshtml"
    using Telerik.Sitefinity.Frontend.Identity.Mvc.Models.UsersList;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\UsersList\Detail.UserDetails.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\UsersList\Detail.UserDetails.cshtml"
    using Telerik.Sitefinity.Security.Claims;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\UsersList\Detail.UserDetails.cshtml"
    using Telerik.Sitefinity.Security.Model;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/UsersList/Detail.UserDetails.cshtml")]
    public partial class Detail_UserDetails : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.UsersList.UserDetailsViewModel>
    {
        public Detail_UserDetails()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 9 "..\..MVC\Views\UsersList\Detail.UserDetails.cshtml"
  
    bool isAuthenticated = false;

    var user = ClaimsManager.GetCurrentIdentity();
    if (user != null)
    {
        isAuthenticated = user.IsAuthenticated;
    }

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 492), Tuple.Create("\"", 530)
            
            #line 19 "..\..MVC\Views\UsersList\Detail.UserDetails.cshtml"
, Tuple.Create(Tuple.Create("", 500), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 500), false)
, Tuple.Create(Tuple.Create(" ", 515), Tuple.Create("media", 516), true)
, Tuple.Create(Tuple.Create(" ", 521), Tuple.Create("sf-media", 522), true)
);

WriteLiteral(">\n\n");

            
            #line 21 "..\..MVC\Views\UsersList\Detail.UserDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 21 "..\..MVC\Views\UsersList\Detail.UserDetails.cshtml"
     if (isAuthenticated)
    {


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"media-left sf-img-thmb\"");

WriteLiteral(">\n            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 628), Tuple.Create("\"", 696)
            
            #line 25 "..\..MVC\Views\UsersList\Detail.UserDetails.cshtml"
, Tuple.Create(Tuple.Create("", 634), Tuple.Create<System.Object, System.Int32>(((SitefinityProfileItemViewModel)Model.Item).AvatarImageUrl
            
            #line default
            #line hidden
, 634), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 697), Tuple.Create("\"", 731)
            
            #line 25 "..\..MVC\Views\UsersList\Detail.UserDetails.cshtml"
            , Tuple.Create(Tuple.Create("", 703), Tuple.Create<System.Object, System.Int32>(Model.Item.Fields.FirstName
            
            #line default
            #line hidden
, 703), false)
);

WriteLiteral(" width=\"100\"");

WriteLiteral(" height=\"100\"");

WriteLiteral(" />\n        </div>\n");

            
            #line 27 "..\..MVC\Views\UsersList\Detail.UserDetails.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"media-body sf-media-body\"");

WriteLiteral(">\n            <h3>");

            
            #line 29 "..\..MVC\Views\UsersList\Detail.UserDetails.cshtml"
            Write((Model.Item.DataItem as SitefinityProfile).GetUserDisplayName());

            
            #line default
            #line hidden
WriteLiteral("</h3>\n            <p>");

            
            #line 30 "..\..MVC\Views\UsersList\Detail.UserDetails.cshtml"
           Write((Model.Item.DataItem as SitefinityProfile).User.Email);

            
            #line default
            #line hidden
WriteLiteral("</p>\n            <p>");

            
            #line 31 "..\..MVC\Views\UsersList\Detail.UserDetails.cshtml"
          Write(Html.Raw((((SitefinityProfileItemViewModel)Model.Item).About)));

            
            #line default
            #line hidden
WriteLiteral("</p>\n        </div>\n");

            
            #line 33 "..\..MVC\Views\UsersList\Detail.UserDetails.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <p>");

            
            #line 36 "..\..MVC\Views\UsersList\Detail.UserDetails.cshtml"
      Write(Html.Resource("NotLoggedInUser"));

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 37 "..\..MVC\Views\UsersList\Detail.UserDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591
