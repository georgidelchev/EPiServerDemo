using EPiServer.Web.Mvc;
using System.Web.Mvc;
using EPiServerDemo.Models.Pages;

namespace EPiServerDemo.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            return View(currentPage);
        }
    }
}