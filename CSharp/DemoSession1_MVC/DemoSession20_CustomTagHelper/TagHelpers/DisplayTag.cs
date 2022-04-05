using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession20_CustomTagHelper.TagHelpers
{
    [HtmlTargetElement("display", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class DisplayTag : TagHelper
    {
        [HtmlAttributeName("fullname")]
        public string fullname { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "";
            output.Content.SetHtmlContent("Hello " + fullname);
        }
    }
}
