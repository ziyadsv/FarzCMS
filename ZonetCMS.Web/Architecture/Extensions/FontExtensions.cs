using ZonetCMS.Entities.Entities;
using ZonetCMS.Web.Architecture.Helpers;

namespace ZonetCMS.Web.Architecture.Extensions
{
    public static class FontExtensions
    {
        public static string CDNFontPath(this Font font)
        {
            var cdnAddress = SettingHelper.Get("CDN Address");

            if (string.IsNullOrWhiteSpace(cdnAddress))
            {
                return font.FontPath;
            }

            return $"{cdnAddress}{font.FontPath}";
        }
    }
}