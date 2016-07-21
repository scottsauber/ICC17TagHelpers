using Markdig;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICC17TagHelpers.TagHelpers
{
    public class MarkdownTagHelper : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var childContent = await output.GetChildContentAsync();
            string rawContent = childContent.GetContent();
            var markdown = Markdown.ToHtml(rawContent);
            output.Content.SetHtmlContent(markdown);
        }
    }
}
