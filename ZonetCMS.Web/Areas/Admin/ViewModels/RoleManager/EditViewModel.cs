using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ZonetCMS.Web.Areas.Admin.ViewModels.RoleManager
{
    public class EditViewModel
    {
        public int RoleId { get; set; }

        [Required]
        [DisplayName("Role Name")]
        public string RoleName { get; set; }
    }
}