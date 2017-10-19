using Models.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DB.Commands.Core.Factories
{
    public class MovieFactory : IMovieFactory
    {
        public Person CreatePerson(string firstName, string lasttName, string job, string movie)
        {
            Person person = new Person()
            {
                FirstName = firstName,
                LastName = lasttName,
                Job = job,
                Movie = movie
            };

            return person;
        }

        public Genre CreateGenre(string name)
        {
            Genre genre = new Genre()
            {
                Name = name
            };

            return genre;
        }

        public Movie CreateMovie(string title, ICollection<Genre> genres, string year, string releaseDate,/* int rating,*/ string synopsis,
           Person writer, Person director, ICollection<Person> cast, decimal budget)
        {
            Movie movie = new Movie()
            {
                Title = title,
                Genres = genres,
                Year = year,
                ReleaseDate = releaseDate,
                //Rating = rating,
                Synopsis = synopsis,
                Writer = writer,
                Director = director,
                Cast = cast,
                Budget = budget
            };

            return movie;
        }



        //public Series CreateSeries(string name, int genreId, /*int rating,*/  int numberOfSeasons, int episodesPerSeason, string ongoing)
        //{
        //    Series series = new Series
        //    {
        //        Name = name,
        //        // Rating = rating,
        //        //NumberOfSeasons = numberOfSeasons,
        //        //EpisodesPerSeason = episodesPerSeason,
        //        //Ongoing = ongoing,
        //    };

        //    return series;
        //}
        public Series CreateSeries(string name, Genre genre)
        {
            Series series = new Series
            {
                Name = name,
                Genre = genre
                //NumberOfSeasons = numberOfSeasons,
                //EpisodesPerSeason = episodesPerSeason,
                //Ongoing = ongoing,
            };

            return series;
        }
    }
}




