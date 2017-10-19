using Models.Framework;
using Movie_DB.Models;
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

        Movie CreateMovie(string name, ICollection<Genre> categories, string year, string releaseDate,string synopsis,
        Person writer, Person director, ICollection<Person> cast, decimal budget);
        Series CreateSeries(string name, Genre genre);
        Genre CreateGenre(string name);
        Synopsis CreateSynopsis(string movieTitle, string text);
    }
}
