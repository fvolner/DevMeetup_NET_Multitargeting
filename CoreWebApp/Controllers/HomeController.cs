using Microsoft.AspNetCore.Mvc;

using Resources;

namespace CoreWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //CookieHelper.AddFakeAuthToken();

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
