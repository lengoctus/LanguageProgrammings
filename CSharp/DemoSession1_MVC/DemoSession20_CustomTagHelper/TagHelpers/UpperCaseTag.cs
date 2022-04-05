using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession20_CustomTagHelper.TagHelpers
{
    [HtmlTargetElement("uppercase", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class UpperCaseTag : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            //  Lay content cua Element
            var content = (await output.GetChildContentAsync()).GetContent();

            output.TagName = "";
            output.Content.SetHtmlContent(content.ToUpper());


        }
    }
}
