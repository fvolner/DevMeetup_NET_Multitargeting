using System.Web;

namespace Cookies
{
    public class CookieService
    {
        public string MyAuthCookie()
        {
            return HttpContext.Current.Request.Cookies["MyToken"]?.Value;
        }


        public void AddFakeAuthToken()
        {
            var cookie = new HttpCookie("MyToken")
            {
                Value = "token value"
            };

            HttpContext.Current.Response.Cookies.Add(cookie);
        }
    }
}
