using winforms_mvp_tutorial.Models;

namespace winforms_mvp_tutorial.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<winforms_mvp_tutorial.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(winforms_mvp_tutorial.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            // Categories seeder
            context.Categories.AddOrUpdate(x => x.Id,
                new Category()
                {
                    Id = 1,
                    CategoryName = "Lemonades",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Category()
                {
                    Id = 2,
                    CategoryName = "Alcohols",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });
        }
    }
}
