using Models.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DB.Commands.Core.Factories
{
    public interface IMovieFactory
    {
        Person CreatePerson(string firstName, string lasttName, string job, string movie);

        Movie CreateMovie(string name, ICollection<Genre> categories, string year, string releaseDate, /*int rating,*/ string synopsis,
            Person writer, Person director, ICollection<Person> cast, decimal budget);

        //Series CreateSeries(string name, int genreId, /*int rating,*/  int numberOfSeasons, int episodesPerSeason, string ongoing);
        Series CreateSeries(string name, Genre genre);
        Genre CreateGenre(string name);
    }
}
