namespace Movie_DB.Migrations
{
    using Models.Framework;
    using System;
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



            //using (StreamReader reader = new StreamReader(@"C:\Users\Admin\Desktop\DB project\TKL-MovieDB\TKL-MovieDB\Movie-DB\XML"))
            //{
            //    string xml = reader.ReadToEnd();
            //    dynamic parsed = JObject.Parse(xml);
            //    foreach (var wrappedSellers in parsed)
            //    {
            //        foreach (var sellers in wrappedSellers)
            //        {
            //            foreach (var seller in sellers)
            //            {
            //                //Seller s = new Seller();
            //                //s.FirstName = seller.firstName;
            //                //s.LastName = seller.lastName;
            //                //string countryName = seller.country;
            //                //Country country = context.Countries.FirstOrDefault(w => w.Name == countryName);
            //                //s.CountryId = country.Id;
            //                //s.Country = country;
            //                //s.Books = new HashSet<Book>();

            //                //context.Sellers.AddOrUpdate(s);
            //            }
            //        }
            //    }
            //}
            //XmlSerializer serializer = new XmlSerializer(typeof(Person));


            
        }
    }
}
