using ZonetCMS.Entities.Entities;
using System.Linq;

namespace ZonetCMS.Entities.Seed
{
    public static class PostCategorySeed
    {
        public static void Seed(PortalEntityModel context)
        {
            if (!context.PostCategories.Any())
                context.PostCategories.Add(new PostCategory { PostCategoryName = "Blog" });
        }
    }
}