using ZonetCMS.Web.ViewModels.Shared;

namespace ZonetCMS.Web.Areas.PageBuilder.ViewModels.Section
{
    public class EditBackgroundImageViewModel
    {
        public int PageAssociationId { get; set; }

        public int SectionId { get; set; }

        public int BackgroundImageId { get; set; }

        public PaginationViewModel MediaLibrary { get; set; }
    }
}