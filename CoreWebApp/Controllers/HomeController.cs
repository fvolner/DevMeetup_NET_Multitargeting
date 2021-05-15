using Cookies;

using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Protection;

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


        public ActionResult FakeAuthEndpoint([FromServices] IDataProtectionProvider dataProtectionProvider)
        {
            var token = CookieHelper.MyAuthCookie(httpContextAccessor);
            var protectedData = ProtectionManager.ProtectMyAuth(token, dataProtectionProvider);

            return View(protectedData);
        }
    }
}
