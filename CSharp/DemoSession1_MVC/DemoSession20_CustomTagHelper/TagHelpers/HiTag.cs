using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession20_CustomTagHelper.TagHelpers
{
    [HtmlTargetElement("hi", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class HiTag : TagHelper
    {
        public string StyleColor { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "p";
            //output.TagMode = TagMode.StartTagAndEndTag;

            var hihi = output.Content.SetHtmlContent("hihihi");

            output.Attributes.Add("style", "color: red");
            output.Content.SetHtmlContent(hihi);
        }
    }
}
