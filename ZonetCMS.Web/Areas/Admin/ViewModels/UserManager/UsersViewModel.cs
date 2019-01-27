using ZonetCMS.Entities.Entities;
using System.Collections.Generic;

namespace ZonetCMS.Web.Areas.Admin.ViewModels.UserManager
{
    public class UsersViewModel
    {
        public IEnumerable<User> Users { get; set; }
    }
}