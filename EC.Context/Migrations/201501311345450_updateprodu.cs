namespace EC.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateprodu : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Vendors", "Product_Id", "dbo.Products");
            DropIndex("dbo.Vendors", new[] { "Product_Id" });
            DropColumn("dbo.Vendors", "Product_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vendors", "Product_Id", c => c.Long());
            CreateIndex("dbo.Vendors", "Product_Id");
            AddForeignKey("dbo.Vendors", "Product_Id", "dbo.Products", "Id");
        }
    }
}
