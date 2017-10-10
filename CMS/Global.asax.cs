using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Telerik.Sitefinity.Abstractions;
using Telerik.Sitefinity.Data;

namespace SitefinityWebApp
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Bootstrapper.Initialized += Bootstrapper_Initialized;
        }

        private void Bootstrapper_Initialized(object sender, ExecutedEventArgs e)
        {
            if (e.CommandName == "Bootstrapped")
            {
                System.Web.Mvc.RouteCollectionExtensions.MapRoute(System.Web.Routing.RouteTable.Routes, 
                    "Classic", 
                    "MyMvc/{controller}/{action}/", 
                    new { controller = "MyTestWidget", action = "Index" });
            }
        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

    }
}