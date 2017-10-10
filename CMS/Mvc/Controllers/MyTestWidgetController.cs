using SitefinityWebApp.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitefinityWebApp.Mvc.Controllers
{
    public class MyTestWidgetController : Controller
    {
        // GET: MyTestWidget
        public ActionResult Index()
        {
            var model = new MyTestWidget();
            model.Message = "Hello World!!";
            return View(model);
        }

        public ActionResult OtherRoute()
        {
            var model = new MyTestWidget();
            model.Message = "Hello World, From Another Route!!";
            return View("Index",model);
        }
    }
}