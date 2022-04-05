using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession20_CustomTagHelper.TagHelpers
{
    [HtmlTargetElement("address", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class AddressTag : TagHelper
    {
        // Declare class ho tro load view tuong ung
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        // Load html
        private IHtmlHelper htmlhelper;

        public AddressTag(IHtmlHelper htmlhelper)
        {
            this.htmlhelper = htmlhelper;
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            (htmlhelper as IViewContextAware).Contextualize(ViewContext);

            htmlhelper.ViewBag.Age = 20;
            var category = new List<string> { "string 1", "string 2", "string 3" };
            htmlhelper.ViewBag.cate = category;

            output.Content.SetHtmlContent(await htmlhelper.PartialAsync("TagHelpers/Address/Index"));
        }
    }
}
