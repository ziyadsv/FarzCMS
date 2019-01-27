﻿using ZonetCMS.Entities.Enumerators;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace ZonetCMS.Web.Areas.Admin.ViewModels.MediaManager
{
    public class UploadImageViewModel
    {
        public int PostId { get; set; }

        [DisplayName("Image")]
        [Required]
        public HttpPostedFileBase AttachedImage { get; set; }

        [Required]
        [DisplayName("Category")]
        public ImageCategory ImageCategory { get; set; }
    }
}