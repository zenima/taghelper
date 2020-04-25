using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Zenima.TagHelpers
{
    /// <summary>
    /// Tag helper to enable conditionally displaying wrapper tags.
    /// </summary>
    [HtmlTargetElement(Attributes = DisplayAttribute)]
    [HtmlTargetElement(Attributes = WrapperAttribute)]
    public class DisplayTagHelper : TagHelper
    {
        internal const string DisplayAttribute = "display";
        internal const string WrapperAttribute = "display-wrapper";

        /// <summary>
        /// Enable/disable rendering tag.
        /// </summary>
        [HtmlAttributeName(DisplayAttribute)]
        public bool Display { get; set; } = true;

        /// <summary>
        /// Enable/disable displaying wrapper tag.
        /// </summary>
        [HtmlAttributeName(WrapperAttribute)]
        public bool DisplayWrapper { get; set; } = true;

        /// <summary>
        /// Processes the 'display' and 'display-wrapper' attributes
        /// and configures tag visibility.
        /// </summary>
        /// <param name="context">TagHelper context.</param>
        /// <param name="output">TagHelper output.</param>
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (context is null)
                throw new ArgumentNullException(nameof(context));
            if (output is null)
                throw new ArgumentNullException(nameof(output));
            
            if (!Display)
            {
                // Hide tag
                output.SuppressOutput();
            }
            else if (!DisplayWrapper)
            {
                // Hide wrapper
                output.TagName = null;
            }
        }
    }
}
