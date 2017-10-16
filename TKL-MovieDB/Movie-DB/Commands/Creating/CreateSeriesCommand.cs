using Movie_DB.Commands.Contracts;
using Movie_DB.Commands.Core.Factories;
using Movie_DB.Core.Providers;
using Movie_DB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Movie_DB.Commands.Creating
{
   public class CreateSeriesCommand : ICommand
    {
        private readonly IMovieFactory factory;
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IMovieDbContext context;
        private List<string> personData = new List<string>();

        public CreateSeriesCommand(MovieDbContext context, IMovieFactory factory, IReader reader, IWriter writer)
        {
            this.context = context;
            this.factory = factory;
            this.reader = reader;
            this.writer = writer;
        }

        public void CollectData()
        {
            writer.WriteLine("Enter First Name:");
            personData.Add(reader.ReadLine());
            writer.WriteLine("Enter Last Name:");
            personData.Add(reader.ReadLine());
            writer.WriteLine("Enter Job:");
            personData.Add(reader.ReadLine());
        }

        public string Execute()
        {
            CollectData();
            //var series = this.factory.CreateSeries();

            //context.SeriesCollection.Add(series);

            //context.SaveChanges();

            return "Series Created";
        }
    }
}
