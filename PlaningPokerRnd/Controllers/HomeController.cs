using System.Web.Mvc;

namespace PlaningPokerRnd.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
