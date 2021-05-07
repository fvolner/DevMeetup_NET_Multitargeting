using System.Web;

namespace Cookies
{
    public class CookieHelper
    {
        public static string MyAuthCookie()
        {
            return HttpContext.Current.Request.Cookies["MyToken"]?.Value;
        }


        public static void AddFakeAuthToken()
        {
            var cookie = new HttpCookie("MyToken")
            {
                Value = "token value"
            };

            HttpContext.Current.Response.Cookies.Add(cookie);
        }
    }
}
