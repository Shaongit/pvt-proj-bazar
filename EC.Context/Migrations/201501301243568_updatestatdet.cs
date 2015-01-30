namespace EC.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatestatdet : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.StaticItemDets");
            AddColumn("dbo.Products", "StaticItemDetId", c => c.Int(nullable: false));
            AddColumn("dbo.StaticItemDets", "Product_Id", c => c.Long());
            AlterColumn("dbo.StaticItemDets", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.StaticItemDets", "Id");
            CreateIndex("dbo.StaticItemDets", "Product_Id");
            AddForeignKey("dbo.StaticItemDets", "Product_Id", "dbo.Products", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StaticItemDets", "Product_Id", "dbo.Products");
            DropIndex("dbo.StaticItemDets", new[] { "Product_Id" });
            DropPrimaryKey("dbo.StaticItemDets");
            AlterColumn("dbo.StaticItemDets", "Id", c => c.Long(nullable: false, identity: true));
            DropColumn("dbo.StaticItemDets", "Product_Id");
            DropColumn("dbo.Products", "StaticItemDetId");
            AddPrimaryKey("dbo.StaticItemDets", "Id");
        }
    }
}
