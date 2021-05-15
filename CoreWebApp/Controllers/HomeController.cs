using Cookies;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Resources;

namespace CoreWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public HomeController(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            CookieHelper.AddFakeAuthToken(httpContextAccessor);

            var banner = ImagesProvider.Kentico();

            return View(banner);
        }


        //public ActionResult FakeAuthEndpoint()
        //{
        //    var token = CookieHelper.MyAuthCookie();
        //    var protectedData = ProtectionManager.ProtectMyAuth(token);

        //    return View(protectedData);
        //}
    }
}
