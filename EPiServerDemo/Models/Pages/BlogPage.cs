using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServerDemo.Models.Blocks;

namespace EPiServerDemo.Models.Pages
{
    [ContentType(
        DisplayName = "Blog Page",
        GUID = "f62c4295-f100-471e-9b63-f9594116b67f",
        Description = "Blog PAGE")]
    public class BlogPage : StandardPage
    {
        [Display(
            Name = "Heading",
            GroupName = SystemTabNames.Content,
            Description = "Page Heading",
            Order = 100)]
        public virtual string Heading { get; set; }

        [Display(
            Name = "Main Body",
            GroupName = SystemTabNames.Content,
            Description = "Main Body",
            Order = 200)]
        public virtual XhtmlString MainBody { get; set; }

        [Display(
            Name = "Book1",
            GroupName = SystemTabNames.Content,
            Description = "Page Book",
            Order = 300)]
        public virtual ContentArea Book1 { get; set; }

    }
}