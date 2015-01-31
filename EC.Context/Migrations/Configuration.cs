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
                new Vendor { Name = "HP", Address = "USA", Description = "NA", IsActive = true, Published = true, Deleted = false, CreateDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Vendor { Name = "Dell", Address = "USA", Description = "NA", IsActive = true, Published = true, Deleted = false, CreateDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Vendor { Name = "ASUS", Address = "USA", Description = "NA", IsActive = true, Published = true, Deleted = false, CreateDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Vendor { Name = "Intel", Address = "USA", Description = "NA", IsActive = true, Published = true, Deleted = false, CreateDate = DateTime.Now, UpdatedDate = DateTime.Now }

                );


            context.Categories.AddOrUpdate(
                p => p.Name,
                new Category
                {
                    Name = "Electronics",
                    Description = "NA",
                    MetaTitle = "Electronics",
                    ShowOnHomePage = true,
                    PictureId = 0,
                    ParentCategoryId = 0,
                    Deleted = false,
                    Published = true,
                    CreateDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    //SubCategories = new List<Category> { }
                },
                new Category { Name = "TV", Description = "NA", MetaTitle = "Book,Study", ShowOnHomePage = true, PictureId = 0, Deleted = false, Published = true, CreateDate = DateTime.Now, UpdatedDate = DateTime.Now, ParentCategoryId = 1 },
                new Category { Name = "Camera", Description = "NA", MetaTitle = "Book,Study", ShowOnHomePage = true, PictureId = 0, Deleted = false, Published = true, CreateDate = DateTime.Now, UpdatedDate = DateTime.Now, ParentCategoryId = 1 },

                                new Category { Name = "Books", Description = "NA", MetaTitle = "Book,Study", ShowOnHomePage = true, PictureId = 0, ParentCategoryId = 0, Deleted = false, Published = true, CreateDate = DateTime.Now, UpdatedDate = DateTime.Now },
                                new Category { Name = "Mobile", Description = "NA", MetaTitle = "Book,Study", ShowOnHomePage = true, PictureId = 0, ParentCategoryId = 0, Deleted = false, Published = true, CreateDate = DateTime.Now, UpdatedDate = DateTime.Now },
                                new Category { Name = "Computers", Description = "NA", MetaTitle = "Book,Study", ShowOnHomePage = true, PictureId = 0, ParentCategoryId = 0, Deleted = false, Published = true, CreateDate = DateTime.Now, UpdatedDate = DateTime.Now },
                                new Category { Name = "Vehicles", Description = "NA", MetaTitle = "Book,Study", ShowOnHomePage = true, PictureId = 0, ParentCategoryId = 0, Deleted = false, Published = true, CreateDate = DateTime.Now, UpdatedDate = DateTime.Now }

                );
            context.StaticItems.AddOrUpdate(
                a => a.StaticName,
                new StaticItem { StaticName = "Price Range" },
                new StaticItem { StaticName = "Sort" }
                );

            context.StaticItemDets.AddOrUpdate(
                b => b.Id,
                new StaticItemDet { StaticItemId = 1, ItemValue = 1, ItemText = "0-1000tk" },
                new StaticItemDet { StaticItemId = 1, ItemValue = 2, ItemText = "1001-2000tk" },
                new StaticItemDet { StaticItemId = 1, ItemValue = 3, ItemText = "2001-3000tk" },
                new StaticItemDet { StaticItemId = 1, ItemValue = 4, ItemText = "3001-4000tk" },
                new StaticItemDet { StaticItemId = 1, ItemValue = 5, ItemText = "4001-5000tk" },
                new StaticItemDet { StaticItemId = 1, ItemValue = 6, ItemText = "More than 5000tk" },
                new StaticItemDet { StaticItemId = 2, ItemValue = 1, ItemText = "Most Sold" },
                new StaticItemDet { StaticItemId = 2, ItemValue = 2, ItemText = "Price High To Low" },
                new StaticItemDet { StaticItemId = 2, ItemValue = 3, ItemText = "Price Low To High" }
                );

            context.Products.AddOrUpdate(
                p => p.Name,
                new Product { Name = "Walton", CategoryId = 2, ShortDescription = "NA", FullDescription = "NA", VendorId = 1, ShowOnHomePage = false, AllowCustomerReviews = false, IsGiftCard = false, IsShipEnabled = false, IsFreeShipping = true, IsActive = true, ShipSeparately = false, StockQuantity = 2, DisplayStockAvailability = false, DisplayStockQuantity = false, UnitPrice = 100, OldPrice = 0, SpecialPrice = 0, HasDiscountsApplied = false, BookQty = 0, LockQty = 0, Published = true, Deleted = false, CreatedDate = DateTime.Now, UserId = 1, StaticItemDetId = 1 });
            //context.UserProfiles.
            //WebSecurity.CreateUserAndAccount("mahedee", "leads@123");

            //WebSecurity.Register("Demo", "123456", "demo@demo.com", true, "Demo", "Demo");

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
