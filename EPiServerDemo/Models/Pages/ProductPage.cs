using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServerDemo.Business.Constants;
using EPiServerDemo.Business.SelectionFactories;
using Geta.Epi.FontThumbnail;

namespace EPiServerDemo.Models.Pages
{
    [ContentType(
        DisplayName = "Product Page",
        GUID = "c96b19a3-f787-476e-989f-86366e28772e",
        Description = "Use this for software products that you sells.",
        GroupName = SiteGroupNames.Specialized)]
    [ThumbnailIcon(FontAwesome.ShoppingBag)]
    [AvailableContentTypes(IncludeOn = new []{typeof(StandardPage)})]
    public class ProductPage : StandardPage
    {
        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);
            Theme = "theme1";
        }

        [Display(
            Name = "Color theme",
            GroupName = SystemTabNames.Content,
            Order = 310)]
        [SelectOne(SelectionFactoryType = typeof(ThemeSelectionFactory))]
        protected virtual string Theme { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Unique selling points",
            GroupName = SystemTabNames.Content,
            Order = 320)]
        [Required]
        public virtual IList<string> UniqueSellingPoints { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Content area",
            GroupName = SystemTabNames.Content,
            Order = 330)]
        public virtual ContentArea ContentArea { get; set; }
    }
}
