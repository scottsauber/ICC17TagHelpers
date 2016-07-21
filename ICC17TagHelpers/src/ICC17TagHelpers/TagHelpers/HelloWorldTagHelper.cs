using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace ICC17TagHelpers.TagHelpers
{
    public class HelloWorldTagHelper : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.SetContent("Hello Iowa Code Camp");
        }
    }
}
