using Doshka.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Doshka.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Doshka.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Doshka.Models.ApplicationDbContext context)
        {
            context.Roles.AddOrUpdate(new IdentityRole()
            {
                Id = "Admin",
                Name = "Admin"
            });

            context.Categories.AddOrUpdate(new Category()
            {
                CategoryId = 1,
                Name = "All categories"
            }, new Category()
            {
                CategoryId = 2,
                Name = "Fashion & Style"
            }, new Category()
            {
                CategoryId = 3,
                Name = "Housing"
            }, new Category()
            {
                CategoryId = 4,
                Name = "Realty"
            }, new Category()
            {
                CategoryId = 5,
                Name = "All for moms & babies"
            }, new Category()
            {
                CategoryId = 6,
                Name = "Auto & transport"
            }, new Category()
            {
                CategoryId = 7,
                Name = "Hobbies, sports & tourism"
            }, new Category()
            {
                CategoryId = 8,
                Name = "Repair and construction"
            }, new Category()
            {
                CategoryId = 9,
                Name = "Toys & hobbies"
            }, new Category()
            {
                CategoryId = 10,
                Name = "Garden"
            }, new Category()
            {
                CategoryId = 11,
                Name = "Wedding"
            }, new Category()
            {
                CategoryId = 12,
                Name = "Entertainment"
            }, new Category()
            {
                CategoryId = 13,
                Name = "Work, business and study"
            }, new Category()
            {
                CategoryId = 14,
                Name = "Service"
            });
        }
    }
}
