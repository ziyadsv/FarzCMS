namespace ZonetCMS.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initFarz : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MenuItems", "parentId", c => c.Int(nullable: false));
            AddColumn("dbo.MenuItems", "isParent", c => c.Boolean(nullable: false));
            AddColumn("dbo.MenuItems", "hasChild", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MenuItems", "hasChild");
            DropColumn("dbo.MenuItems", "isParent");
            DropColumn("dbo.MenuItems", "parentId");
        }
    }
}
