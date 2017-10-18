using Models.Framework;
using Movie_DB.Commands.Admin;
using Movie_DB.Commands.Core.Factories;
using Movie_DB.Core;
using Movie_DB.Data;
using Movie_DB.Migrations;
using Movie_DB.Ninject;
using Ninject;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Movie_DB
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<MovieDbContext, Configuration>());

            //IKernel kernel = new StandardKernel(new MovieModule());

            //IEngine engine = kernel.Get<Engine>();
            //engine.Start();

            //using(var context = new MovieDbContext())
            //{
            //    var genre = context.Genres.Where(x=>x.Name == "comedy").ToString();
            //    Console.WriteLine(genre.ToString());
            //}

            //XmlDocument doc = new XmlDocument();
            //doc.Load(@"C:\Users\Admin\Desktop\DB project\TKL-MovieDB\TKL-MovieDB\Movie-DB\XML\movie.xml");

            //XmlNode node = doc.DocumentElement.SelectSingleNode("/person/firstName");

            //foreach (XmlNode n in doc.DocumentElement.ChildNodes)
            //{
            //    string text = n.InnerText; //or loop through its children as well
            //    Console.WriteLine(text);
            //}


            // JSON manual test
            //Genre genre = new Genre()
            //{
            //    Name = "Comedy"
            //};

            //JSONController.SaveToFile(genre);


            using (StreamReader reader = new StreamReader(@"C:\Users\Admin\Desktop\DB project\TKL-MovieDB\TKL-MovieDB\Movie-DB\XML\movie.xml"))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(@"C:\Users\Admin\Desktop\DB project\TKL-MovieDB\TKL-MovieDB\Movie-DB\XML\movie.xml");

                List<string> list = XDocument.Parse(xmlDoc.ToString())
                     .Descendants("person")
                     .Select(x => x.ToString())
                     .ToList();

                foreach (var it in list)
                {
                    Console.WriteLine(it.ToString());
                }
                //XmlNodeList peopleCollection = xmlDoc.GetElementsByTagName("People");
                //Console.WriteLine(peopleCollection);

                

                //foreach (var person in peopleCollection)
                //{
                //    XmlNodeList personFirstName = xmlDoc.GetElementsByTagName("firstName");
                //    XmlNodeList personLastName = xmlDoc.GetElementsByTagName("lastName");
                //    XmlNodeList personJob = xmlDoc.GetElementsByTagName("job");

                //    Console.WriteLine(personFirstName[0].InnerText);
                //    Console.WriteLine(personLastName[0].InnerText);
                //    Console.WriteLine(personJob[0].InnerText);
                //}

            }
        }
    }
}
