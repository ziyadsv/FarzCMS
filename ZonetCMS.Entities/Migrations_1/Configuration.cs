namespace ZonetCMS.Entities.Migrations
{
    using Seed;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ZonetCMS.Entities.PortalEntityModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
          //  AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(ZonetCMS.Entities.PortalEntityModel context)
        {
            ThemeSeed.Seed(context);
            RoleSeed.Seed(context);
            SettingSeed.Seed(context);
            PostCategorySeed.Seed(context);
            PageSectionTypeSeed.Seed(context);
            PageComponentTypeSeed.Seed(context);
            MediaSeed.Seed(context);
            CopySeed.Seed(context);
            context.SaveChanges();

            MenuSeed.Seed(context);
            PageSeed.Seed(context);
            PostSeed.Seed(context);
        }
    }
}
