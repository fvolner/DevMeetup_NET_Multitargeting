using Microsoft.AspNetCore.Http;

namespace Cookies
{
    public class CookieService
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public CookieService(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public string MyAuthCookie()
        {
            return httpContextAccessor.HttpContext.Request.Cookies["MyToken"];
        }

        public void AddFakeAuthToken()
        {
            httpContextAccessor.HttpContext.Response.Cookies.Append("MyToken", "token value");
        }
    }
}
