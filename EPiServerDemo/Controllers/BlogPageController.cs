using System.Web.Mvc;
using EPiServer;
using EPiServerDemo.Models.Pages;

namespace EPiServerDemo.Controllers
{
    public class BlogPageController : PageControllerBase<BlogPage>
    {
        public BlogPageController(
            IContentLoader loader) 
            : base(loader)
        {
        }

        public ActionResult Index(BlogPage currentPage)
        {
            return this.View(this.CreatePageViewModel(currentPage));
        }
    }
}