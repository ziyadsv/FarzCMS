using ZonetCMS.Entities.Entities;
using System.Collections.Generic;
using System.ComponentModel;

namespace ZonetCMS.Web.Areas.Admin.ViewModels.UserManager
{
    public class RolesViewModel
    {
        public int? UserId { get; set; }

        [DisplayName("Roles")]
        public List<string> SelectedRoleList { get; set; } = new List<string>();

        public List<Role> RoleList { get; set; }
    }
}