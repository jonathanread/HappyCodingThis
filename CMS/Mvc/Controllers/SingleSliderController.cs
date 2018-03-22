using SitefinityWebApp.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Sitefinity.DynamicModules;
using Telerik.Sitefinity.DynamicModules.Model;
using Telerik.Sitefinity.Model;
using Telerik.Sitefinity.Mvc;
using Telerik.Sitefinity.Utilities.TypeConverters;
using Telerik.Sitefinity.RelatedData;
using Telerik.Sitefinity.Libraries.Model;
using Telerik.Sitefinity.Pages.Model;
using Telerik.Sitefinity.Modules.Pages;
using Telerik.Sitefinity.Web;

namespace SitefinityWebApp.Mvc.Controllers
{
	[ControllerToolboxItem(Name = "SingleSlider", Title = "Single Slider", SectionName = "MvcWidgets")]
	public class SingleSliderController : Controller
	{
		public string SliderId { get; set; }//Id of Slider set from UI
		public string SliderItem { get; set; }//Slider JSON, only simple properties, used to show info in UI like Title

		public ActionResult Index()
		{
			var model = new SingleSliderModel();
			var item = GetDynamicContent();
			if (item != null)
			{
				model.Title = item.GetValue("Title").ToString();
				model.ButtonText = item.GetValue("ButtonText").ToString();
				model.AdditionalContent = item.GetValue("AdditionalContent").ToString();
				SetModelImage(model, item);
				SetModelPageUrl(model, item);
			}
			return View("Default", model);
		}

		private void SetModelPageUrl(SingleSliderModel model, DynamicContent item)
		{
			var page = item.GetRelatedItems<PageNode>("Page").SingleOrDefault();//This is single selection related items on dynamic module
			if (page != null)
			{
				model.PageUrl = UrlPath.ResolveUrl(page.GetUrl(), true, true);
			}
		}

		private void SetModelImage(SingleSliderModel model, DynamicContent item)
		{
			var image = item.GetRelatedItems<Image>("Image").SingleOrDefault();//This is single selection related items on dynamic module
			if (image != null)
			{
				model.Image = image;
			}
		}

		private DynamicContent GetDynamicContent()
		{
			var providerName = String.Empty;//Will use site default provider when no value sent
			if (!SliderId.IsNullOrWhitespace())
			{
				DynamicModuleManager dynamicModuleManager = DynamicModuleManager.GetManager(providerName);
				Type sliderType = TypeResolutionService.ResolveType("Telerik.Sitefinity.DynamicTypes.Model.Sliders.Slider");

				// This is how we get the slider item by ID, from the item set in UI picker
				return dynamicModuleManager.GetDataItem(sliderType, new Guid(SliderId));
			}
			else
			{
				return null;
			}
		}
	}
}