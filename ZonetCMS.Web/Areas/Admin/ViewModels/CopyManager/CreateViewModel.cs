using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ZonetCMS.Web.Areas.Admin.ViewModels.CopyManager
{
    public class CreateViewModel
    {
        [Required]
        [DisplayName("Copy Name")]
        public string CopyName { get; set; }

        [Required]
        [DisplayName("Copy Body")]
        public string CopyBody { get; set; }
    }
}