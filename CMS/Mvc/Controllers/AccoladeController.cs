using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;
using Telerik.Sitefinity.Modules.Blogs;
using Telerik.Sitefinity.GenericContent.Model;
using Telerik.Sitefinity.Modules.News;
using Telerik.Sitefinity.Personalization;

namespace SitefinityWebApp.Mvc.Controllers
{
	[ControllerToolboxItem(Name = "Accolade", Title = "Accolade", SectionName = "MvcWidgets")]
	public class AccoladeController : Controller, IPersonalizable
	{
		/// <summary>
		/// Gets or sets the message.
		/// </summary>
		[Category("String Properties")]
		public string IconClass { get; set; }

		public bool UseBlogCount { get; set; }

		public bool UseNewsCount { get; set; }

		public string NumberOfAccolades { get; set; }

		[Category("String Properties")]
		public string Caption { get; set; }

		/// <summary>
		/// This is the default Action.
		/// </summary>
		public ActionResult Index()
		{
			var model = new AccoladeModel();

			model.Caption = Caption;
			model.IconClass = IconClass;

			if (UseBlogCount)
			{
				model.NumberOfAccolades = BlogsManager.GetManager().GetBlogPosts()
					.Where(bp => bp.Status == ContentLifecycleStatus.Live && bp.Visible).Count();
			}
			else if (UseNewsCount)
			{
				model.NumberOfAccolades = NewsManager.GetManager().GetNewsItems()
					.Where(bp => bp.Status == ContentLifecycleStatus.Live && bp.Visible).Count();
			}
			else
			{
				SetNumberOfAccolades(model);
			}

			model.UseBlogCount = UseBlogCount;
			model.UseNewsCount = UseNewsCount;

			return View("Default", model);
		}

		private void SetNumberOfAccolades(AccoladeModel model)
		{
			int numberOfAccoldates;
			int.TryParse(NumberOfAccolades, out numberOfAccoldates);
			model.NumberOfAccolades = numberOfAccoldates;
		}
	}
}