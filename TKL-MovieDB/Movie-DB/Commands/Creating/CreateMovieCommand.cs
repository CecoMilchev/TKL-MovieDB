using Models.Framework;
using Movie_DB.Commands.Abstarcts;
using Movie_DB.Commands.Contracts;
using Movie_DB.Commands.Core.Factories;
using Movie_DB.Core.Providers;
using Movie_DB.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DB.Commands.Creating
{
   public class CreateMovieCommand : AbstractCommand, ICommand
    {
        private List<string> movieData = new List<string>();
        private List<string> movieCategories = new List<string>();
        private List<string> movieWriters = new List<string>();
        private List<string> movieDirectors = new List<string>();
        private List<string> movieCast = new List<string>();

        public CreateMovieCommand(IMovieDbContext context, IMovieFactory factory, IReader reader, IWriter writer)
            : base(context, factory, reader, writer)
        {
        }

        public void CollectData()
        {
            writer.WriteLine("Enter Movie Title: ");
            movieData.Add(reader.ReadLine());

            writer.WriteLine("Enter Genres: ");
            movieCategories.AddRange(reader.ReadLine().Split(' '));

            writer.WriteLine("Enter Year: ");
            movieData.Add(reader.ReadLine());

            writer.WriteLine("Enter Release Date: ");
            movieData.Add(reader.ReadLine());

            writer.WriteLine("Enter Rating: ");
            movieData.Add(reader.ReadLine());

            writer.WriteLine("Enter Synopsis: ");
            movieData.Add(reader.ReadLine());

            writer.WriteLine("Enter Writers: ");
            movieWriters.AddRange(reader.ReadLine().Split(' '));

            writer.WriteLine("Enter Directors: ");
            movieDirectors.AddRange(reader.ReadLine().Split(' '));

            writer.WriteLine("Enter Cast: ");
            movieCast.AddRange(reader.ReadLine().Split(' '));

            writer.WriteLine("Enter Budget: ");
            movieData.Add(reader.ReadLine());
        }

        public string Execute()
        {
            CollectData();
            //var movie = this.factory.CreateMovie(movieData[0],  movieData[1], movieData[3],
            //    movieData[4], movieData[5], movieData[6], movieData[7], movieData[8], movieData[9]);

            //context.Movies.Add(movie);

            context.SaveChanges();

            return "Movie Created!";
        }



    }
}
