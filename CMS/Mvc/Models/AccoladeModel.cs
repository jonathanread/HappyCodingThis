using System;
using System.Linq;

namespace SitefinityWebApp.Mvc.Models
{
    public class AccoladeModel
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public string IconClass { get; set; }

        public bool UseBlogCount { get; set; }

        public bool UseNewsCount { get; set; }

        public int NumberOfAccolades { get; set; }

        public string Caption { get; set; }
    }
}