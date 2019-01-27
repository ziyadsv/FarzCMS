using ZonetCMS.Entities.Entities;
using System.Collections.Generic;

namespace ZonetCMS.Web.Areas.PageBuilder.ViewModels.Section
{
    public class RestoreViewModel
    {
        public int PageSectionId { get; set; }

        public List<PageSectionBackup> PageSectionBackup { get; set; }
    }
}