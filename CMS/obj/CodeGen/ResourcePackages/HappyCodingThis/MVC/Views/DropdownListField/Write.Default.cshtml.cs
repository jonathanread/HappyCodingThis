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

namespace SitefinityWebApp.ResourcePackages.HappyCodingThis.MVC.Views.DropdownListField
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
    
    #line 4 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DropdownListField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DropdownListField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DropdownListField\Write.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DropdownListField\Write.Default.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/HappyCodingThis/MVC/Views/DropdownListField/Write.Default.csht" +
        "ml")]
    public partial class Write_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.DropdownListField.DropdownListFieldViewModel>
    {
        public Write_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 8 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DropdownListField\Write.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 333), Tuple.Create("\"", 367)
            
            #line 10 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DropdownListField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 341), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 341), false)
, Tuple.Create(Tuple.Create(" ", 356), Tuple.Create("form-group", 357), true)
);

WriteLiteral(" data-sf-role=\"dropdown-list-field-container\"");

WriteLiteral(">\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteAttribute("value", Tuple.Create(" value=\'", 473), Tuple.Create("\'", 529)
, Tuple.Create(Tuple.Create("", 481), Tuple.Create("{", 481), true)
, Tuple.Create(Tuple.Create(" ", 482), Tuple.Create("\"required\":", 483), true)
, Tuple.Create(Tuple.Create(" ", 494), Tuple.Create("\"", 495), true)
            
            #line 11 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DropdownListField\Write.Default.cshtml"
  , Tuple.Create(Tuple.Create("", 496), Tuple.Create<System.Object, System.Int32>(Model.RequiredViolationMessage
            
            #line default
            #line hidden
, 496), false)
, Tuple.Create(Tuple.Create("", 527), Tuple.Create("\"}", 527), true)
);

WriteLiteral(" />\n    <label");

WriteAttribute("for", Tuple.Create(" for=\'", 544), Tuple.Create("\'", 576)
            
            #line 12 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DropdownListField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 550), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Dropdown")
            
            #line default
            #line hidden
, 550), false)
);

WriteLiteral(">\n");

WriteLiteral("        ");

            
            #line 13 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DropdownListField\Write.Default.cshtml"
   Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral("\n    </label>\n");

            
            #line 15 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DropdownListField\Write.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 15 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DropdownListField\Write.Default.cshtml"
     if (!string.IsNullOrEmpty(Model.MetaField.Description)) 
    { 

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 17 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DropdownListField\Write.Default.cshtml"
                         Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 18 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DropdownListField\Write.Default.cshtml"
    } 

            
            #line default
            #line hidden
WriteLiteral("\n    <select");

WriteAttribute("id", Tuple.Create(" id=\'", 774), Tuple.Create("\'", 805)
            
            #line 20 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DropdownListField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 779), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Dropdown")
            
            #line default
            #line hidden
, 779), false)
);

WriteLiteral(" data-sf-role=\"dropdown-list-field-select\"");

WriteAttribute("name", Tuple.Create(" name=\"", 848), Tuple.Create("\"", 881)
            
            #line 20 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DropdownListField\Write.Default.cshtml"
             , Tuple.Create(Tuple.Create("", 855), Tuple.Create<System.Object, System.Int32>(Model.MetaField.FieldName
            
            #line default
            #line hidden
, 855), false)
);

WriteLiteral(" ");

            
            #line 20 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DropdownListField\Write.Default.cshtml"
                                                                                                                   Write(MvcHtmlString.Create(Model.ValidationAttributes));

            
            #line default
            #line hidden
WriteLiteral(" class=\"form-control\">\n");

            
            #line 21 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DropdownListField\Write.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 21 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DropdownListField\Write.Default.cshtml"
     foreach (var choice in Model.Choices)
    {
        string value = !string.IsNullOrEmpty(Model.Value as string) ? Model.Value as string : string.Empty;
 		bool isSelected = (!string.IsNullOrEmpty(value) && choice == value) ||
 						  (string.IsNullOrEmpty(value) && !Model.IsRequired && choice == Model.MetaField.DefaultValue as string);
 
 		var optionAttributes = isSelected ? "selected" : string.Empty;
        var optionValue = Model.IsRequired && choice == Model.Choices.FirstOrDefault() ? string.Empty : choice;


            
            #line default
            #line hidden
WriteLiteral("        <option ");

            
            #line 30 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DropdownListField\Write.Default.cshtml"
           Write(optionAttributes);

            
            #line default
            #line hidden
WriteLiteral(" value=\"");

            
            #line 30 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DropdownListField\Write.Default.cshtml"
                                    Write(optionValue);

            
            #line default
            #line hidden
WriteLiteral("\">");

            
            #line 30 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DropdownListField\Write.Default.cshtml"
                                                  Write(choice);

            
            #line default
            #line hidden
WriteLiteral("</option>\n");

            
            #line 31 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DropdownListField\Write.Default.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    </select>\n    \n</div>\n\n");

            
            #line 36 "..\..\ResourcePackages\HappyCodingThis\MVC\Views\DropdownListField\Write.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/DropdownListField/dropdown-list-field.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
