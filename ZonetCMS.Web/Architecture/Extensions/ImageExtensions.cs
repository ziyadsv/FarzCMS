using ZonetCMS.Entities.Entities;
using ZonetCMS.Web.Architecture.Helpers;

namespace ZonetCMS.Web.Architecture.Extensions
{
    public static class ImageExtensions
    {
        public static string CDNImagePath(this Image image)
        {
            var cdnAddress = SettingHelper.Get("CDN Address");

            if (string.IsNullOrWhiteSpace(cdnAddress))
            {
                return image.ImagePath;
            }

            return $"{cdnAddress}{image.ImagePath}";
        }
    }
}