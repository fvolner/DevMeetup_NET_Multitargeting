using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcUtils
{
    public static class ByteToHexConvertHtmlHelper
    {
        public static HtmlString ConvertByteToString(this HtmlHelper htmlHelper, byte[] byteArray)
        {
            return new HtmlString(string.Concat(byteArray.Select(b => b.ToString("X2"))));
        }
    }
}
