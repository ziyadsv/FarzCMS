﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZonetCMS.Entities.Entities
{
    public class MenuItem
    {
        [Key]
        public int MenuItemId { get; set; }

        [ForeignKey("Menu")]
        public int MenuId { get; set; }

        public virtual MenuSystem Menu { get; set; }

        [Required]
        public string LinkText { get; set; }

        public string LinkIcon { get; set; }

        [Required]
        public string LinkURL { get; set; }

        public int parentId { get; set; }
        public bool isParent { get; set; }
        public bool hasChild { get; set; }

        public virtual ICollection<MenuItemRole> MenuItemRoles { get; set; }
    }
}