using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Razor.TagHelpers;

using System.Linq;

namespace MvcUtils
{
    public class ByteToHexConvertTagHelper : TagHelper
    {
        public byte[] ByteArray { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = null;
            output.Content.SetHtmlContent(new HtmlString(string.Concat(ByteArray.Select(b => b.ToString("X2")))));
        }
    }
}
