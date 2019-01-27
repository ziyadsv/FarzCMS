﻿using System.ComponentModel;

namespace ZonetCMS.Web.Areas.PageBuilder.ViewModels.Section
{
    public class EditBackgroundColourViewModel
    {
        public int PageAssociationId { get; set; }

        public int PageSectionId { get; set; }

        [DisplayName("Colour")]
        public string BackgroundColour { get; set; }
    }
}