using System.Web.Mvc;
using EPiServer.Web.Mvc;
using EPiServerDemo.Models.Pages;
using EPiServerDemo.Models.ViewModels;

namespace EPiServerDemo.Controllers
{
    public class ProductPagePartialController : PartialContentController<ProductPage>
    {
        public override ActionResult Index(ProductPage currentPage)
        {
            return this.PartialView(PageViewModel.Create(currentPage));
        }
    }
}