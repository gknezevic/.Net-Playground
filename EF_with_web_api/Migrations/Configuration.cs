namespace EF_with_web_api.Migrations
{
    using EF_with_web_api.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EF_with_web_api.Models.EF_with_web_apiContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EF_with_web_api.Models.EF_with_web_apiContext context)
        {

            context.Authors.AddOrUpdate(x => x.Id, 
                new Author() {Id = 1, Name = "Dostojevski" },
                new Author() { Id = 2, Name = "Lav Tolstoj"}
                );

            context.Books.AddOrUpdate(x => x.Id,
                new Book() { Id = 1, Title = "Braca Karamazovi", Genre = "Triler", Year = 1870, AuthorId = 1, Price = 9.99M },
                new Book() { Id = 2, Title = "Idiot", Genre = "Novel", Year = 1877, AuthorId = 1, Price = 19.99M },
                new Book() { Id = 3, Title = "War and peace", Genre = "Novel", Year = 1901, AuthorId = 2, Price = 29.99M }
                );

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
