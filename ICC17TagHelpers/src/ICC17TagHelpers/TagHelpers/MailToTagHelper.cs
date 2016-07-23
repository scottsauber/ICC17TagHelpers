using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICC17TagHelpers.TagHelpers
{
    public class MailToTagHelper : TagHelper
    {
        public string Email { get; set; }
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var content = output.GetChildContentAsync();
            output.Attributes.Add("href", $"mailto:{Email}");


            output.TagName = "a";
        }
    }
}
