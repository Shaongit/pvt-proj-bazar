namespace EC.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updateuser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfile", "FullName", c => c.String());
            AddColumn("dbo.UserProfile", "MobNumber", c => c.String());
            AddColumn("dbo.UserProfile", "Password", c => c.String());
            DropColumn("dbo.UserProfile", "FirstName");
            DropColumn("dbo.UserProfile", "LastName");
            DropColumn("dbo.UserProfile", "NewProp");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserProfile", "NewProp", c => c.String());
            AddColumn("dbo.UserProfile", "LastName", c => c.String());
            AddColumn("dbo.UserProfile", "FirstName", c => c.String());
            DropColumn("dbo.UserProfile", "Password");
            DropColumn("dbo.UserProfile", "MobNumber");
            DropColumn("dbo.UserProfile", "FullName");
        }
    }
}
