using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.Data.DataProcessing.Processors;
using Telerik.Sitefinity.Data.DataProcessing.Processors.XssSanitizerHelpers;
using Telerik.Sitefinity.Data.DataProcessing.Processors.XssSanitizerHelpers.Contracts;

namespace HappyCodingThis
{
    public class CustomXssSanitizerDataProcessor : XssSanitizerDataProcessor
    {
        protected override ISitefinityHtmlSanitizer Sanitizer
        {
            get
            {
                var sanitizer = base.Sanitizer as GanssHtmlSanitizerWrapper;
                sanitizer.Sanitizer.AllowedSchemes.Add("tel");
                sanitizer.Sanitizer.AllowedSchemes.Add("mailto");
                return sanitizer;
            }
        }
    }
}
