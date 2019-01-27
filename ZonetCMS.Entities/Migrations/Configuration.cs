namespace ZonetCMS.Entities.Migrations
{
    using Seed;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ZonetCMS.Entities.PortalEntityModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
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