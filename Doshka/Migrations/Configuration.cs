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
        }
    }
}
