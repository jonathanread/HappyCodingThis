/* ------------------------------------------------------------------------------
<auto-generated>
    This file was generated by Sitefinity CLI v1.0.0.2
</auto-generated>
------------------------------------------------------------------------------ */

using SitefinityWebApp.Mvc.Models;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using Telerik.Sitefinity.Personalization;

namespace SitefinityWebApp.Mvc.Controllers
{
	[ControllerToolboxItem(Name = "SeasonedContent_MVC", Title = "Seasoned Content", SectionName = "CustomWidgets")]
	public class SeasonedContentController : Controller, IPersonalizable
	{
		// GET: SeasonedContent
		public ActionResult Index()
		{
			var model = new SeasonedContentModel();
			model.Message = this.Message;
			model.SeasonCssClass = this.SeasonCssClass;
			return View("Default", model);
		}

		public string Message { get; set; }
		public string SeasonCssClass { get; set; }
	}
}