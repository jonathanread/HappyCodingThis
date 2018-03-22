using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telerik.Sitefinity.Abstractions;
using Telerik.Sitefinity.Multisite;
using Telerik.Sitefinity.Services;
using Telerik.Sitefinity.Utilities.TypeConverters;

namespace SitefinityWebApp.Helpers
{
	public static class MultisiteHelpers
	{
		/// <summary>
		/// Returns the provider name for the current site.
		/// </summary>
		/// <param name="moduleName">Name of the Sitefinity module you want to know the prover name.</param>
		/// <returns>The sites provider name of empty if not found or in single site mode.</returns>
		public static string GetCurrentProvider(string moduleName)
		{
			var context = SystemManager.CurrentContext;
			string providerName = string.Empty;

			if (moduleName.Contains("DynamicTypes"))
			{
				moduleName = TypeResolutionService.ResolveType(moduleName).FullName;
			}
			try
			{
				if (context.IsMultisiteMode)
				{
					providerName = context.MultisiteContext.CurrentSite.GetProviders(moduleName).Select(p => p.ProviderName).FirstOrDefault();
				}
			}
			catch (Exception ex)
			{
				Log.Write("Provider not found for " + moduleName, System.Diagnostics.TraceEventType.Error);
				Log.Write(ex, System.Diagnostics.TraceEventType.Error);
			}

			return providerName;
		}

		/// <summary>
		/// Gets current site Id
		/// </summary>
		/// <returns>Guid or null</returns>
		public static Guid? GetCurrentSiteId()
		{
			var context = SystemManager.CurrentContext;
			Guid? siteId = null;
			try
			{
				if (context.IsMultisiteMode)
				{
					siteId = context.MultisiteContext.CurrentSite.Id;
				}
				else
				{
					siteId = context.CurrentSite.Id;
				}
			}
			catch (Exception ex)
			{
				Log.Write("Error retrieving site Id", System.Diagnostics.TraceEventType.Error);
				Log.Write(ex, System.Diagnostics.TraceEventType.Error);
			}

			return siteId;
		}
	}
}