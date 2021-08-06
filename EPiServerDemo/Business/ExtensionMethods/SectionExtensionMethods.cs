using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using System.Linq;

namespace AlloyTraining.Business.ExtensionMethods
{
    public static class SectionExtensionMethods
    {
        // Gets the top level page of the section this page is in. Used to build our submenu.
        public static IContent GetSection(this ContentReference contentLink)
        {
            var loader = ServiceLocator.Current.GetInstance<IContentLoader>();
            var currentContent = loader.Get<IContent>(contentLink);
            if (currentContent.ParentLink != null && currentContent.ParentLink.CompareToIgnoreWorkID(ContentReference.StartPage))
            {
                return currentContent;
            }

            return loader.GetAncestors(contentLink)
                .OfType<PageData>()
                .SkipWhile(x => x.ParentLink == null || !x.ParentLink.CompareToIgnoreWorkID(ContentReference.StartPage))
                .FirstOrDefault();
        }
    }
}