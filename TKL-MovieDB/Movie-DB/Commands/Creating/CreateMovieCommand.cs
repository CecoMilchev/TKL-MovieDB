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
            movieGenres.AddRange(reader.ReadLine().Split(' '));

            writer.WriteLine("Enter Year: ");
            movieData.Add(reader.ReadLine()); //movieData[1]

            writer.WriteLine("Enter Release Date: ");
            movieData.Add(reader.ReadLine()); //movieData[2]

            writer.WriteLine("Enter Synopsis: ");
            movieData.Add(reader.ReadLine()); //movieData[3]

            writer.WriteLine("Enter Writers: ");
            movieWriters.AddRange(reader.ReadLine().Split(' '));

            writer.WriteLine("Enter Director: ");
            movieData.Add(reader.ReadLine()); //movieData[4]

            writer.WriteLine("Enter Cast: ");
            movieCast.AddRange(reader.ReadLine().Split(' '));

            writer.WriteLine("Enter Budget: "); //movieData[5]
            movieData.Add(reader.ReadLine());
        }

        public string Execute()
        {
            CollectData();
            var movie = this.factory.CreateMovie();
            movie.Title = movieData[0]; //title

            foreach (var genre in movieGenres)
            {
                var genreFromContext = context.Genres.Where(r => r.Name == genre).First();

                if (genre == genreFromContext.Name)
                {
                    movie.Genres.Add(genreFromContext);
                }
                else
                {
                    context.Genres.Add(new Genre() { Name = genre });
                }

            }

            movie.Year = movieData[1]; //year
            movie.ReleaseDate = movieData[2]; // release date
            movie.Synopsis = movieData[3];

            foreach (var writer in movieWriters) // writers
            {
                var writerFromContext = context.Persons.Where(r => r.FirstName == writer).First();

                if (writer == writerFromContext.Name)
                {
                    movie.Genres.Add(genreFromContext);
                }
                else
                {
                    context.Genres.Add(new Genre() { Name = genre });
                }

            }
            context.Movies.Add(movie);

            context.SaveChanges();

            return "Movie Created!";
        }



    }
}
