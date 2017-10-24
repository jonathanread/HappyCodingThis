using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "CrewMembersExpertise", Title = "Crew Members Expertise", SectionName = "Telerik.Sitefinity.DynamicTypes.Model.Crew")]
    public class CrewMembersExpertiseController : Controller
    {
        /// <summary>
        /// This is the default Action.
        /// </summary>
        public ActionResult Index()
        {
            var model = new CrewMembersExpertiseModel();

            return View("Default", model);
        }
    }
}