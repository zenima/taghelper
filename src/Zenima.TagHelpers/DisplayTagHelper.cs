using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Zenima.TagHelpers
{
    /// <summary>
    /// Tag helper to enable conditionally displaying wrapper tags.
    /// </summary>
    [HtmlTargetElement(Attributes = DisplayAttribute)]
    [HtmlTargetElement(Attributes = WrapperAttribute)]
    public class DisplayTagHelper : TagHelper
    {
        private const string DisplayAttribute = "display";
        private const string WrapperAttribute = "display-wrapper";

        /// <summary>
        /// Enable/disable rendering tag.
        /// </summary>
        [HtmlAttributeName(DisplayAttribute)]
        public bool Display { get; set; } = true;

        /// <summary>
        /// Enable/disable rendering wrapper tag.
        /// </summary>
        [HtmlAttributeName(WrapperAttribute)]
        public bool DisplayWrapper { get; set; } = true;

        /// <inheritdoc />
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
