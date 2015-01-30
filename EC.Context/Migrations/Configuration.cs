namespace EC.Context.Migrations
{
    using EC.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebMatrix.WebData;
    using System.Web.Security;
    
    internal sealed class Configuration : DbMigrationsConfiguration<ECommerceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ECommerceContext context)
        {
            context.Vendors.AddOrUpdate(
                v => v.Name,
                new Vendor { Name="HP", Address="USA", Description="NA", IsActive=true, Published=true, Deleted=false, CreateDate=DateTime.Now, UpdatedDate = DateTime.Now},
                new Vendor { Name = "Dell", Address = "USA", Description = "NA", IsActive = true, Published = true, Deleted = false, CreateDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Vendor { Name = "ASUS", Address = "USA", Description = "NA", IsActive = true, Published = true, Deleted = false, CreateDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Vendor { Name = "Intel", Address = "USA", Description = "NA", IsActive = true, Published = true, Deleted = false, CreateDate = DateTime.Now, UpdatedDate = DateTime.Now }
                
                );

            
            //WebSecurity.CreateUserAndAccount("mahedee", "leads@123");
            //Roles.CreateRole("Super Admin");
            //Roles.CreateRole("Admin");
            //Roles.CreateRole("User");
            //Roles.CreateRole("Customer");
            //Roles.CreateRole("Visitor");
            //Roles.CreateRole("Member");

            //Roles.AddUserToRole("mahedee", "Admin");

            
            
            //Roles
            //WebSecurity.R
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
