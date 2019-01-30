namespace Admin.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.Products", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.Invoices", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.Orders", "UpdatedDate", c => c.DateTime());
            DropColumn("dbo.Categories", "UpdatedTime");
            DropColumn("dbo.Products", "UpdatedTime");
            DropColumn("dbo.Invoices", "UpdatedTime");
            DropColumn("dbo.Orders", "UpdatedTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "UpdatedTime", c => c.DateTime());
            AddColumn("dbo.Invoices", "UpdatedTime", c => c.DateTime());
            AddColumn("dbo.Products", "UpdatedTime", c => c.DateTime());
            AddColumn("dbo.Categories", "UpdatedTime", c => c.DateTime());
            DropColumn("dbo.Orders", "UpdatedDate");
            DropColumn("dbo.Invoices", "UpdatedDate");
            DropColumn("dbo.Products", "UpdatedDate");
            DropColumn("dbo.Categories", "UpdatedDate");
        }
    }
}
