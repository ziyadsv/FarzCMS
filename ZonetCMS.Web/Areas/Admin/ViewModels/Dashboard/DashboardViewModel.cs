using ZonetCMS.Entities.Entities;
using System.Collections.Generic;

namespace ZonetCMS.Web.Areas.Admin.ViewModels.Dashboard
{
    public class DashboardViewModel
    {
        public List<Image> Media { get; set; }

        public Post LatestPost { get; set; }
    }
}