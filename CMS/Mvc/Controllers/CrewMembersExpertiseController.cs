using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;
using Telerik.Sitefinity.Modules.Pages;
using Telerik.Sitefinity.Web;
using Telerik.Sitefinity.Personalization;

namespace SitefinityWebApp.Mvc.Controllers
{
	[ControllerToolboxItem(Name = "CrewMembersExpertise", Title = "Crew Members Expertise", SectionName = "Telerik.Sitefinity.DynamicTypes.Model.Crew")]
	public class CrewMembersExpertiseController : Controller, IPersonalizable
	{
		public string SelectedItem { get; set; }

		public string SelectedItemId { get; set; }
		/// <summary>
		/// This is the default Action.
		/// </summary>
		public ActionResult Index()
		{
			var model = new CrewMembersExpertiseModel();
			model.DetailPageUrl = GetDetailPageUrl();
			return View("Default", model);
		}

		private string GetDetailPageUrl()
		{
			string url = null;
			if (!SelectedItemId.IsNullOrWhitespace())
			{
				var PageId = Guid.Parse(SelectedItemId);
				if (PageId != Guid.Empty && PageId != null)
				{
					PageManager pMan = PageManager.GetManager();
					var page = pMan.GetPageNode(PageId);
					if (page != null)
					{
						url = UrlPath.ResolveUrl(page.GetUrl(), true, false);
					}
				}
			}
			return url;
		}
	}
}