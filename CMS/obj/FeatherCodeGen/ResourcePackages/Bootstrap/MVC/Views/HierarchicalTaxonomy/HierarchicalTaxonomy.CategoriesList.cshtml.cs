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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.HierarchicalTaxonomy
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/HierarchicalTaxonomy/HierarchicalTaxonomy.CategoriesList.cshtml")]
    public partial class HierarchicalTaxonomy_CategoriesList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Taxonomies.Mvc.Models.TaxonomyViewModel>
    {
        public HierarchicalTaxonomy_CategoriesList()
        {
        }
        public override void Execute()
        {
WriteLiteral("<ul");

WriteAttribute("class", Tuple.Create(" class=\"", 79), Tuple.Create("\"", 116)
            
            #line 3 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
, Tuple.Create(Tuple.Create("", 87), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 87), false)
, Tuple.Create(Tuple.Create(" ", 102), Tuple.Create("list-unstyled", 103), true)
);

WriteLiteral(">\n");

            
            #line 4 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 4 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
     foreach (var taxon in Model.Taxa)
    {

            
            #line default
            #line hidden
WriteLiteral("        <li>\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 191), Tuple.Create("\"", 208)
            
            #line 7 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
, Tuple.Create(Tuple.Create("", 198), Tuple.Create<System.Object, System.Int32>(taxon.Url
            
            #line default
            #line hidden
, 198), false)
);

WriteLiteral(">");

            
            #line 7 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
                            Write(taxon.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\n\n");

            
            #line 9 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
            
            
            #line default
            #line hidden
            
            #line 9 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
             if (Model.ShowItemCount)
            {
                

            
            #line default
            #line hidden
WriteLiteral("                <span");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 12 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
                                    Write(Html.Raw(string.Format("({0})", taxon.Count)));

            
            #line default
            #line hidden
WriteLiteral("</span>\n");

            
            #line 13 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
                
            }

            
            #line default
            #line hidden
WriteLiteral("        </li>\n");

            
            #line 16 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"

    }

            
            #line default
            #line hidden
WriteLiteral("</ul>");

        }
    }
}
#pragma warning restore 1591
