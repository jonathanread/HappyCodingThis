using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telerik.Sitefinity.Libraries.Model;

namespace SitefinityWebApp.Mvc.Models
{
    public class SingleSliderModel
    {
	   public string Title { get; set; }
	   public string ButtonText { get; set; }
	   public string AdditionalContent { get; set; }
	   public string PageUrl { get; set; }
	   public Image Image { get; set; }
    }
}