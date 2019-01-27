using ZonetCMS.Entities.Entities;
using System.Collections.Generic;

namespace ZonetCMS.Web.Areas.PageBuilder.ViewModels.Component
{
    public class AddViewModel
    {
        public string ContainerElementId { get; set; }

        public IEnumerable<PageComponentType> PageComponentTypeList { get; set; }
    }
}