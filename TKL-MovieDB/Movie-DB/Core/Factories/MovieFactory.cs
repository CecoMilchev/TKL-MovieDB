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
        public Person CreatePerson(string firstName, string lasttName, string job)
        {
            Person person = new Person()
            {
                FirstName = firstName,
                LastName = lasttName,
                Job = job,
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

        public Movie CreateMovie(string title, ICollection<Genre> genres, string year, string releaseDate, int rating, string synopsis,
           ICollection<Person> writers, ICollection<Person> directors, ICollection<Person> cast, decimal budget)
        {
            Movie movie = new Movie()
            {
                Title = title,
                Genres = genres,
                Year = year,
                ReleaseDate = releaseDate,
                Rating = rating,
                Synopsis = synopsis,
                Writers = writers,
                Directors = directors,
                Cast = cast,
                Budget = budget
            };

            return movie;
        }



        public Series CreateSeries(string name, int genreId, /*int rating,*/  int numberOfSeasons, int episodesPerSeason, string ongoing)
        {
            Series series = new Series
            {
                Name = name,
                // Rating = rating,
                GenreId = genreId,
                NumberOfSeasons = numberOfSeasons,
                EpisodesPerSeason = episodesPerSeason,
                Ongoing = ongoing,
            };

            return series;
        }
    }
}




