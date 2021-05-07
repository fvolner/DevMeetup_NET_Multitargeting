using Cookies;

using Protection;

using Resources;

using System.Web.Mvc;

namespace DevMeetup.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CookieHelper.AddFakeAuthToken();

            var banner = ImagesProvider.Kentico();
            return View(banner);
        }


        public ActionResult FakeAuthEndpoint()
        {
            var token = CookieHelper.MyAuthCookie();
            var protectedData = ProtectionManager.ProtectMyAuth(token);

            return View(protectedData);
        }
    }
}