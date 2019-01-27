using ZonetCMS.Entities.Entities;
using System.Collections.Generic;

namespace ZonetCMS.Web.Areas.Admin.ViewModels.CopyManager
{
    public class CopyViewModel
    {
        public IEnumerable<CopyItem> CopyList { get; set; }
    }
}