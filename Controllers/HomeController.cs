using System.Web.Mvc;
using Orchard.Themes;

namespace SkyWin.Controllers {
    [Themed]
    public class HomeController : Controller {
        public ActionResult Index() {
            return View("SkyWin");
        }
    }
}