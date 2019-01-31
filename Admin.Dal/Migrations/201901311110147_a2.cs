namespace Admin.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Products", new[] { "SupProductId" });
            AddColumn("dbo.Products", "Description", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "SupProductId", c => c.Guid());
            CreateIndex("dbo.Products", "SupProductId");
            DropColumn("dbo.Products", "Descriptio");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Descriptio", c => c.Int(nullable: false));
            DropIndex("dbo.Products", new[] { "SupProductId" });
            AlterColumn("dbo.Products", "SupProductId", c => c.Guid(nullable: false));
            DropColumn("dbo.Products", "Description");
            CreateIndex("dbo.Products", "SupProductId");
        }
    }
}
