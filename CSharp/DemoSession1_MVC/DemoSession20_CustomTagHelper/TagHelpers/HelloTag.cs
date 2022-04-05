using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession20_CustomTagHelper.TagHelpers
{
    [HtmlTargetElement("hello", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class HelloTag : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

            output.TagName = "span";

            //  Khi goi toi hello se in chu dam, nghieng
            output.Content.SetHtmlContent("<b><i>Hello Word</i></b>");

        }
    }
}
