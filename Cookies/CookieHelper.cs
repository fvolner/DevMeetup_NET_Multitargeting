#if NETSTANDARD
using Microsoft.AspNetCore.Http; 
#endif

namespace Cookies
{
    public class CookieHelper
    {
#if NETFRAMEWORK
        public static string MyAuthCookie()
        {
            return new CookieService().MyAuthCookie();
        }


        public static void AddFakeAuthToken()
        {
            new CookieService().AddFakeAuthToken();
        }
#endif
#if NETSTANDARD
        public static string MyAuthCookie(IHttpContextAccessor httpContextAccessor)
        {
            return new CookieService(httpContextAccessor).MyAuthCookie();
        }


        public static void AddFakeAuthToken(IHttpContextAccessor httpContextAccessor)
        {
            new CookieService(httpContextAccessor).AddFakeAuthToken();
        }
#endif
    }
}
