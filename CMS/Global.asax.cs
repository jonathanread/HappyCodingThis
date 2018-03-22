using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Telerik.Sitefinity.Abstractions;
using Telerik.Sitefinity.Data;
using Telerik.Sitefinity.Multisite;
using Telerik.Sitefinity.Services;

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

		}

		protected void Application_Error(object sender, EventArgs e)
		{

		}
	}
}