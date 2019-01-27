namespace ZonetCMS.Entities.Initialisers
{
    using ZonetCMS.Entities.Migrations;
    using System.Data.Entity;

    internal class MigrateDatabaseToLatestVersion : MigrateDatabaseToLatestVersion<PortalEntityModel, Configuration>
    {
        public override void InitializeDatabase(PortalEntityModel context)
        {
            base.InitializeDatabase(context);

            Seed(context);
        }

        public virtual void Seed(PortalEntityModel context)
        {
        }
    }
}