using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "Accolade", Title = "Accolade", SectionName = "MvcWidgets")]
    public class AccoladeController : Controller
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        [Category("String Properties")]
        public string IconClass { get; set; }

        public bool UseBlogCount { get; set; }

        public bool UseNewsCount { get; set; }

        public int NumberOfAccolades { get; set; }

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
            model.NumberOfAccolades = NumberOfAccolades;
            model.UseBlogCount = UseBlogCount;
            model.UseNewsCount = UseNewsCount;

            return View("Default", model);
        }
    }
}