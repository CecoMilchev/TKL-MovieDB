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
        private List<string> movieGenres = new List<string>();
        private List<string> movieWriters = new List<string>();
        private List<string> movieDirectors = new List<string>();
        private List<string> movieCast = new List<string>();

        public CreateMovieCommand(IMovieDbContext context, IMovieFactory factory, IReader reader, IWriter writer)
            : base(context, factory, reader, writer)
        {
        }

        public void CollectData()
        {
            writer.WriteLine("Enter Movie Title: ");  // movieData 0
            movieData.Add(reader.ReadLine()); 

            writer.WriteLine("Enter Genres: "); 
            movieGenres.AddRange(reader.ReadLine().Split(' '));

            writer.WriteLine("Enter Year: "); // movieData 1
            movieData.Add(reader.ReadLine());

            writer.WriteLine("Enter Release Date: "); // movieData 2
            movieData.Add(reader.ReadLine());

            writer.WriteLine("Enter Rating: ");  // movieData 3
            movieData.Add(reader.ReadLine());

            writer.WriteLine("Enter Synopsis: "); // movieData 4
            movieData.Add(reader.ReadLine());

            writer.WriteLine("Enter Writers: ");
            movieWriters.AddRange(reader.ReadLine().Split(' '));

            writer.WriteLine("Enter Directors: ");
            movieDirectors.AddRange(reader.ReadLine().Split(' '));

            writer.WriteLine("Enter Cast: ");
            movieCast.AddRange(reader.ReadLine().Split(' '));

            writer.WriteLine("Enter Budget: "); // movieData 5
            movieData.Add(reader.ReadLine());
        }

        public string Execute()
        {
            CollectData();

            foreach (var genre in movieGenres)
            {
                var genreFromContext = context.Genres.Where(r => r.Name == genre).First();
                                    
                if (genre == genreFromContext.ToString())
                {

                }
            }

            var movie = this.factory.CreateMovie(movieData[0], movieGenres, movieData[1],
                movieData[2], int.Parse(movieData[3]), movieData[4], movieWriters, movieDirectors, movieCast, decimal.Parse(movieData[5]));

            //context.Movies.Add(movie);

            context.SaveChanges();

            return "Movie Created!";
        }



    }
}
