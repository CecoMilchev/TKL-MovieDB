namespace Movie_DB.Migrations
{
    using Models;
    using Movie_DB.Commands.Admin;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using System.Xml;
    using System.Xml.Serialization;

    internal sealed class Configuration : DbMigrationsConfiguration<Movie_DB.Data.MovieDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(Movie_DB.Data.MovieDbContext context)
        {
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

            //using (StreamReader reader = new StreamReader(@"C:\Users\Admin\Desktop\DB project\TKL-MovieDB\TKL-MovieDB\Movie-DB\XML\movie.xml"))
            //{
            //    XmlDocument doc = new XmlDocument();
            //    doc.Load(@"C:\Users\Admin\Desktop\DB project\TKL-MovieDB\TKL-MovieDB\Movie-DB\XML\movie.xml");

            //    var people = doc.DocumentElement;
            //    if (!context.Persons.Any())
            //    {
            //        foreach (XmlElement person in people)
            //        {
            //            var personFirstName = person["firstName"];
            //            var personLastName = person["lastName"];
            //            var personJob = person["job"];

            //            var myPerson = new Person()
            //            {
            //                FirstName = personFirstName.InnerText,
            //                LastName = personLastName.InnerText,
            //                Job = personJob.InnerText
            //            };
            //            context.Persons.Add(myPerson);
            //        }
            //    }
            //    context.SaveChanges();
            //}
            var genres = JSONController.ReadGenresFromJSON();
            foreach (var g in genres)
            {
                context.Genres.Add(g);
            }
            context.SaveChanges();
        }
    }
}

