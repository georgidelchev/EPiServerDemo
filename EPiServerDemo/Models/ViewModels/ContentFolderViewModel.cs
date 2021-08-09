using EPiServer.Core;

namespace EPiServerDemo.Models.ViewModels
{
    public class ContentFolderViewModel
    {
        public ContentFolder CurrentFolder { get; set; }

        public int ItemsCount { get; set; }
    }
}
