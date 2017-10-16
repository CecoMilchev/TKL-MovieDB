using Movie_DB.Commands.Abstarcts;
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
   public class CreateSeriesCommand : AbstractCommand, ICommand
    {
        private List<string> seriesData = new List<string>();

        public CreateSeriesCommand(IMovieDbContext context, IMovieFactory factory, IReader reader, IWriter writer)
            : base(context, factory, reader, writer)
        {
        }

        public void CollectData()
        {
            writer.WriteLine("Enter Series Name:");
            seriesData.Add(reader.ReadLine());
            writer.WriteLine("Enter Number Of Seasons:");
            seriesData.Add(reader.ReadLine());
            writer.WriteLine("Enter Episodes Per Season:");
            seriesData.Add(reader.ReadLine());
            writer.WriteLine("Enter Series ongoing status (yes/no):");
            seriesData.Add(reader.ReadLine());
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
