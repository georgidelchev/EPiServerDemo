using EPiServer;
using System.Web.Mvc;
using EPiServerDemo.Models.Pages;

namespace EPiServerDemo.Controllers
{
    public class ProductPageController : PageControllerBase<ProductPage>
    {
        public ProductPageController(IContentLoader loader)
            : base(loader)
        {
        }

        public ActionResult Index(ProductPage currentPage)
        {
            return this.View(this.CreatePageViewModel(currentPage));
        }
    }
}