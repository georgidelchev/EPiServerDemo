using System.Collections.Generic;
using EPiServer.Core;
using EPiServerDemo.Models.Pages;

namespace EPiServerDemo.Models.ViewModels
{
    public interface IPageViewModel<T>
        where T : SitePageData
    {
        T CurrentPage { get; set; }

        StartPage StartPage { get; set; }

        IEnumerable<SitePageData> MenuPages { get; set; }

        IContent Section { get; set; }
    }
}
