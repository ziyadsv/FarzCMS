using System.ComponentModel.DataAnnotations;

namespace ZonetCMS.Entities.Entities
{
    public class Setting
    {
        [Key]
        public int SettingId { get; set; }

        [Required]
        public string SettingName { get; set; }

        public string SettingValue { get; set; }
    }
}