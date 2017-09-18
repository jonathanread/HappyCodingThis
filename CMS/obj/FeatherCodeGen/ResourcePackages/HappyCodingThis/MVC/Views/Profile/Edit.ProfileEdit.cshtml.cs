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

namespace SitefinityWebApp.ResourcePackages.HappyCodingThis.MVC.Views.Profile
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
    
    #line 3 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 7 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    using Telerik.Sitefinity.Utilities;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Profile/Edit.ProfileEdit.cshtml")]
    public partial class Edit_ProfileEdit : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.Profile.ProfileEditViewModel>
    {
        public Edit_ProfileEdit()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 9 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top"));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 10 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/jquery.validate/1.8.1/jquery.validate.js", "top"));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 11 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/mvc/4.0/jquery.validate.unobtrusive.min.js", "top"));

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 507), Tuple.Create("\"", 530)
            
            #line 13 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
, Tuple.Create(Tuple.Create("", 515), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 515), false)
);

WriteLiteral(">\n\n\t<h3>");

            
            #line 15 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
   Write(Html.Resource("EditProfileLink"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\n\n");

            
            #line 17 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    
            
            #line default
            #line hidden
            
            #line 17 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
     if (Model.ShowProfileChangedMsg)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"alert alert-success\"");

WriteLiteral(">");

            
            #line 19 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                    Write(Html.Resource("ChangesAreSaved"));

            
            #line default
            #line hidden
WriteLiteral("</div>\n");

            
            #line 20 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 22 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    
            
            #line default
            #line hidden
            
            #line 22 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
     using (Html.BeginFormSitefinity("Index", "EditProfileForm", FormMethod.Post, new { enctype = "multipart/form-data" }))
    {
        

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"media sf-profile\"");

WriteLiteral(">\n        <div");

WriteLiteral(" class=\"media-left sf-pr-xl\"");

WriteLiteral(">\n");

WriteLiteral("            ");

            
            #line 27 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
       Write(Html.HiddenFor(u => u.DeletePicture, new Dictionary<string, object>() { { "data-sf-role", "edit-profile-delete-picture" } }));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("            ");

            
            #line 28 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
       Write(Html.HiddenFor(u => u.DefaultAvatarUrl, new Dictionary<string, object>() { { "data-sf-role", "edit-profile-default-avatar-url" } }));

            
            #line default
            #line hidden
WriteLiteral("\n            <div");

WriteLiteral(" class=\"media-object\"");

WriteLiteral(">\n            \t<div");

WriteLiteral(" class=\"sf-profile-avatar\"");

WriteLiteral(">\n\t                <img");

WriteLiteral(" data-sf-role=\"edit-profile-user-image\"");

WriteAttribute("src", Tuple.Create(" src=\"", 1354), Tuple.Create("\"", 1381)
            
            #line 31 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
, Tuple.Create(Tuple.Create("", 1360), Tuple.Create<System.Object, System.Int32>(Model.AvatarImageUrl
            
            #line default
            #line hidden
, 1360), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 1382), Tuple.Create("\"", 1403)
            
            #line 31 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                 , Tuple.Create(Tuple.Create("", 1388), Tuple.Create<System.Object, System.Int32>(Model.UserName
            
            #line default
            #line hidden
, 1388), false)
);

WriteLiteral(" width=\"100\"");

WriteLiteral(" height=\"100\"");

WriteLiteral("/>\n\t                ");

WriteLiteral("\n\t            </div>\n\n\t            <div>\n\t                <input");

WriteLiteral(" type=\"file\"");

WriteLiteral(" data-sf-role=\"edit-profile-upload-picture-input\"");

WriteLiteral(" name=\"UploadedImage\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(" />\n\t                <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-sf-role=\"edit-profile-upload-picture-button\"");

WriteLiteral(">");

            
            #line 37 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                              Write(Html.Resource("EditProfileUploadImage"));

            
            #line default
            #line hidden
WriteLiteral("</a>\n\t            </div>\n            </div>\n\n        </div> \n\t\t\n        <div");

WriteLiteral(" class=\"media-body\"");

WriteLiteral(">\n");

            
            #line 44 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
             
            
            #line default
            #line hidden
            
            #line 44 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
              if (!string.IsNullOrEmpty(ViewBag.ErrorMessage))
            {


            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(">\n");

WriteLiteral("                    ");

            
            #line 48 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
               Write(ViewBag.ErrorMessage);

            
            #line default
            #line hidden
WriteLiteral("\n                </div>\n");

            
            #line 50 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"

            }

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n                <label>\n");

WriteLiteral("                    ");

            
            #line 54 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
               Write(Html.Resource("EditProfileFirstName"));

            
            #line default
            #line hidden
WriteLiteral("\n                </label>\n");

WriteLiteral("                ");

            
            #line 56 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
           Write(Html.TextBoxFor(u => u.Profile["FirstName"], new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n                \n");

            
            #line 58 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 58 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                 if (Html.ValidationMessageFor(u => u.Profile["FirstName"]) != null)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"has-error\"");

WriteLiteral(">\n                        <span");

WriteLiteral(" class=\"help-block\"");

WriteLiteral(">");

            
            #line 61 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                            Write(Html.ValidationMessageFor(u => u.Profile["FirstName"]));

            
            #line default
            #line hidden
WriteLiteral("</span>\n                    </div>\n");

            
            #line 63 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                } 

            
            #line default
            #line hidden
WriteLiteral("            </div>\n        \n            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n                <label>\n");

WriteLiteral("                    ");

            
            #line 68 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
               Write(Html.Resource("EditProfileLastName"));

            
            #line default
            #line hidden
WriteLiteral("\n                </label>\n");

WriteLiteral("                ");

            
            #line 70 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
           Write(Html.TextBoxFor(u => u.Profile["LastName"], new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n                \n");

            
            #line 72 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 72 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                 if (Html.ValidationMessageFor(u => u.Profile["LastName"]) != null)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"has-error\"");

WriteLiteral(">\n                        <span");

WriteLiteral(" class=\"help-block\"");

WriteLiteral(">");

            
            #line 75 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                            Write(Html.ValidationMessageFor(u => u.Profile["LastName"]));

            
            #line default
            #line hidden
WriteLiteral("</span>\n                    </div>\n");

            
            #line 77 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                } 

            
            #line default
            #line hidden
WriteLiteral("            </div>\t\t\n\t\t\t\n            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n                <label>\n");

WriteLiteral("                    ");

            
            #line 82 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
               Write(Html.Resource("EditProfileNickname"));

            
            #line default
            #line hidden
WriteLiteral("\n                </label>\n");

WriteLiteral("                ");

            
            #line 84 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
           Write(Html.TextBoxFor(u => u.Profile["Nickname"], new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n                \n");

            
            #line 86 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 86 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                 if (Html.ValidationMessageFor(u => u.Profile["Nickname"]) != null)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"has-error\"");

WriteLiteral(">\n                        <span");

WriteLiteral(" class=\"help-block\"");

WriteLiteral(">");

            
            #line 89 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                            Write(Html.ValidationMessageFor(u => u.Profile["Nickname"]));

            
            #line default
            #line hidden
WriteLiteral("</span>\n                    </div>\n");

            
            #line 91 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                } 

            
            #line default
            #line hidden
WriteLiteral("            </div>\n\n            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n                <label>\n");

WriteLiteral("                    ");

            
            #line 96 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
               Write(Html.Resource("EditProfileAbout"));

            
            #line default
            #line hidden
WriteLiteral("\n                </label>\n");

WriteLiteral("               ");

            
            #line 98 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
          Write(Html.TextAreaFor(u => u.Profile["About"], new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n\n            </div>\n        \n\t\t\n");

            
            #line 103 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
		    
            
            #line default
            #line hidden
            
            #line 103 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
             if (string.IsNullOrEmpty(Model.ExternalProviderName))
			{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n\t\t\t\t\t<label>\n");

WriteLiteral("\t\t\t\t\t\t");

            
            #line 107 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                   Write(Html.Resource("EditProfileEmail"));

            
            #line default
            #line hidden
WriteLiteral("\n\t\t\t\t\t</label>\n");

WriteLiteral("\t\t\t\t\t");

            
            #line 109 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
               Write(Html.TextBoxFor(u => u.Email, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n\t\t\t\t\t\n");

            
            #line 111 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
					
            
            #line default
            #line hidden
            
            #line 111 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                     if (Html.ValidationMessageFor(u => u.Email) != null)
					{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t\t<div");

WriteLiteral(" class=\"has-error\"");

WriteLiteral(">\n\t\t\t\t\t\t\t<span");

WriteLiteral(" class=\"help-block\"");

WriteLiteral(">");

            
            #line 114 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                Write(Html.ValidationMessageFor(u => u.Email));

            
            #line default
            #line hidden
WriteLiteral("</span>\n\t\t\t\t\t\t</div>\n");

            
            #line 116 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
					} 

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t</div>\n");

            
            #line 118 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
				

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t<div");

WriteLiteral(" class=\"sf-mb-xl\"");

WriteLiteral("><a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-sf-role=\"edit-profile-change-password-button\"");

WriteLiteral(">");

            
            #line 119 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                                Write(Html.Resource("EditProfileChangePasswordButton"));

            
            #line default
            #line hidden
WriteLiteral("</a></div>\n");

            
            #line 120 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"


            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t<div");

WriteLiteral(" data-sf-role=\"edit-profile-change-password-holder\"");

WriteLiteral(" style=\"display:none\"");

WriteLiteral(">\n\n\t\t\t\t\t<h4>");

            
            #line 123 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                   Write(Html.Resource("EditProfileEditChangePasswordHeader"));

            
            #line default
            #line hidden
WriteLiteral("</h4>\n\t\t\t\t\n\t\t\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n\t\t\t\t\t\t<label>\n");

WriteLiteral("\t\t\t\t\t\t\t");

            
            #line 127 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                       Write(Html.Resource("EditProfileOldPassword"));

            
            #line default
            #line hidden
WriteLiteral("\n\t\t\t\t\t\t</label>\n\n");

WriteLiteral("\t\t\t\t\t\t");

            
            #line 130 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                   Write(Html.PasswordFor(u => u.OldPassword, new { @class = "form-control", autocomplete = "off" }));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 132 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
						
            
            #line default
            #line hidden
            
            #line 132 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                         if (Html.ValidationMessageFor(u => u.OldPassword) != null)
						{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t\t\t<div");

WriteLiteral(" class=\"has-error\"");

WriteLiteral(">\n\t\t\t\t\t\t\t\t<span");

WriteLiteral(" class=\"help-block\"");

WriteLiteral(">");

            
            #line 135 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                    Write(Html.ValidationMessageFor(u => u.OldPassword));

            
            #line default
            #line hidden
WriteLiteral("</span>\n\t\t\t\t\t\t\t</div>\n");

            
            #line 137 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
						} 

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t</div>\n\n\t\t\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n\t\t\t\t\t\t<label>\n");

WriteLiteral("\t\t\t\t\t\t\t");

            
            #line 142 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                       Write(Html.Resource("EditProfileNewPassword"));

            
            #line default
            #line hidden
WriteLiteral("\n\t\t\t\t\t\t</label>\n");

WriteLiteral("\t\t\t\t\t\t");

            
            #line 144 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                   Write(Html.PasswordFor(u => u.NewPassword, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 146 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
						
            
            #line default
            #line hidden
            
            #line 146 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                         if (Html.ValidationMessageFor(u => u.NewPassword) != null)
						{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t\t\t<div");

WriteLiteral(" class=\"has-error\"");

WriteLiteral(">\n\t\t\t\t\t\t\t\t<span");

WriteLiteral(" class=\"help-block\"");

WriteLiteral(">");

            
            #line 149 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                    Write(Html.ValidationMessageFor(u => u.NewPassword));

            
            #line default
            #line hidden
WriteLiteral("</span>\n\t\t\t\t\t\t\t</div>\n");

            
            #line 151 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
						} 

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t</div>\n\n\t\t\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n\t\t\t\t\t\t<label>\n");

WriteLiteral("\t\t\t\t\t\t\t");

            
            #line 156 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                       Write(Html.Resource("EditProfileRepeatPassword"));

            
            #line default
            #line hidden
WriteLiteral("\n\t\t\t\t\t\t</label>\n");

WriteLiteral("\t\t\t\t\t\t");

            
            #line 158 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                   Write(Html.PasswordFor(u => u.RepeatPassword, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n\t\t\t\t\t\t\n");

            
            #line 160 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
						
            
            #line default
            #line hidden
            
            #line 160 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                         if (Html.ValidationMessageFor(u => u.RepeatPassword) != null)
						{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t\t\t<div");

WriteLiteral(" class=\"has-error\"");

WriteLiteral(">\n\t\t\t\t\t\t\t\t<span");

WriteLiteral(" class=\"help-block\"");

WriteLiteral(">");

            
            #line 163 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                    Write(Html.ValidationMessageFor(u => u.RepeatPassword));

            
            #line default
            #line hidden
WriteLiteral("</span>\n\t\t\t\t\t\t\t</div>\n");

            
            #line 165 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
						} 

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t</div>\n\t\t\t\t</div>\n");

            
            #line 168 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
			}
			else
			{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t<h4>");

            
            #line 171 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
               Write(string.Format(Html.Resource("RegistratedWithExternal"), Model.ExternalProviderName));

            
            #line default
            #line hidden
WriteLiteral("</h4>\n");

            
            #line 172 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
			

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n\t\t\t\t\t<label>\n");

WriteLiteral("\t\t\t\t\t\t");

            
            #line 175 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                   Write(Html.Resource("EditProfileEmail"));

            
            #line default
            #line hidden
WriteLiteral("\n\t\t\t\t\t</label>\n\t\t\t\t\t<div>\n");

WriteLiteral("\t\t\t\t\t\t");

            
            #line 178 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                   Write(Html.HiddenFor(u => u.Email));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("\t\t\t\t\t\t");

            
            #line 179 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                   Write(Model.Email);

            
            #line default
            #line hidden
WriteLiteral("\n\t\t\t\t\t</div>\n\t\t\t\t</div>\n");

            
            #line 182 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
				

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n\t\t\t\t\t<label>\n");

WriteLiteral("\t\t\t\t\t\t");

            
            #line 185 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                   Write(Html.Resource("Password"));

            
            #line default
            #line hidden
WriteLiteral("\n\t\t\t\t\t</label>\n\t\t\t\t\t<div>\n");

WriteLiteral("\t\t\t\t\t\t");

            
            #line 188 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                   Write(string.Format(Html.Resource("ExternalProviderNoPassword"), Model.ExternalProviderName));

            
            #line default
            #line hidden
WriteLiteral("\n\t\t\t\t\t</div>\n\t\t\t\t</div>\n");

            
            #line 191 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
			}		

            
            #line default
            #line hidden
WriteLiteral("\t\t\n");

            
            #line 193 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
            
            
            #line default
            #line hidden
            
            #line 193 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
             if (SystemManager.IsDesignMode)
            {

            
            #line default
            #line hidden
WriteLiteral("                <button");

WriteLiteral(" data-sf-role=\"profile-submit\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">");

            
            #line 195 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                       Write(Html.Resource("EditProfileSave"));

            
            #line default
            #line hidden
WriteLiteral("</button>\n");

            
            #line 196 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
            }
            else 
            {

            
            #line default
            #line hidden
WriteLiteral("                <button");

WriteLiteral(" data-sf-role=\"profile-submit\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">");

            
            #line 199 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                       Write(Html.Resource("EditProfileSave"));

            
            #line default
            #line hidden
WriteLiteral("</button>\n");

            
            #line 200 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 202 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
            
            
            #line default
            #line hidden
            
            #line 202 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
             if (SystemManager.IsPreviewMode)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"has-error\"");

WriteLiteral(" data-sf-role=\"profile-submit-preview-message\"");

WriteLiteral(" style=\"display:none\"");

WriteLiteral(">\n                    <span");

WriteLiteral(" class=\"help-block\"");

WriteLiteral("><span");

WriteLiteral(" class=\"field-validation-error\"");

WriteLiteral(">");

            
            #line 205 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                             Write(Html.Resource("PreviewProfileSaveMessage"));

            
            #line default
            #line hidden
WriteLiteral("</span></span>\n                </div>\n");

            
            #line 207 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\n     </div>\n");

            
            #line 210 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\n\n");

            
            #line 213 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
  
	bool hasPasswordErrors = ViewBag.HasPasswordErrors is bool && ViewBag.HasPasswordErrors == true;

            
            #line default
            #line hidden
WriteLiteral("\n\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"has-password-errors\"");

WriteAttribute("value", Tuple.Create(" value=\"", 7733), Tuple.Create("\"", 7789)
            
            #line 217 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
, Tuple.Create(Tuple.Create("", 7741), Tuple.Create<System.Object, System.Int32>(hasPasswordErrors.ToString().ToLowerInvariant()
            
            #line default
            #line hidden
, 7741), false)
);

WriteLiteral(" />\n \n");

            
            #line 219 "..\..MVC\Views\Profile\Edit.ProfileEdit.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Profile/profile-edit.js"), "bottom"));

            
            #line default
            #line hidden
WriteLiteral("\n");

        }
    }
}
#pragma warning restore 1591
