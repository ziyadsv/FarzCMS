using ZonetCMS.Entities.Entities;
using System.Collections.Generic;

namespace ZonetCMS.Web.Areas.Admin.ViewModels.BlogManager
{
    public class PostsViewModel
    {
        public List<Post> Posts { get; set; }

        public IEnumerable<PostCategory> PostCategories { get; set; }
    }
}