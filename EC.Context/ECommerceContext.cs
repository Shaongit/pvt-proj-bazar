using EC.Model;
using EC.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Security;


namespace EC.Context
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext()
            : base("DefaultConnection")
        {

        }

        //public DbSet<UserProfile> UserProfiles { get; set; }
        //public DbSet<Category> Categories { get; set; }
        //public DbSet<Product> Products { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Vendor> Vendors { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //modelBuilder.Entity<Project>().
            //    HasMany(i => i.Users).
            //    WithMany(c => c.Projects).
            //    Map(mc =>
            //    {
            //        mc.MapLeftKey("ProjectId");
            //        mc.MapRightKey("UserId");
            //        mc.ToTable("ProjectUsers");
            //    });

            //modelBuilder.Entity<Task>().
            //    HasMany(i => i.Users).
            //    WithMany(c => c.Tasks).
            //    Map(mc =>
            //    {
            //        mc.MapLeftKey("TaskId");
            //        mc.MapRightKey("UserId");
            //        mc.ToTable("TaskUsers");
            //    });

            //modelBuilder.Entity<Task>().
            //   HasMany(i => i.Followers).
            //   WithMany(c => c.FollowerTasks).
            //   Map(mc =>
            //   {
            //       mc.MapRightKey("TaskId");
            //       mc.MapLeftKey("UserId");
            //       mc.ToTable("TaskFollowers");
            //   });

            //modelBuilder.Entity<Task>().
            //  HasMany(i => i.Labels).
            //  WithMany(c => c.Tasks).
            //  Map(mc =>
            //  {
            //      mc.MapRightKey("TaskId");
            //      mc.MapLeftKey("LabelId");
            //      mc.ToTable("TaskLabels");
            //  });

            //modelBuilder.Entity<Project>()
            //    .HasMany(i => i.ProjectOwners)
            //    .WithMany(c => c.OwnerProjects)
            //    .Map(mc =>
            //    {
            //        mc.MapRightKey("UserId");
            //        mc.MapLeftKey("ProjectID");
            //        mc.ToTable("ProjectOwners");
            //    });

        }
    }
}