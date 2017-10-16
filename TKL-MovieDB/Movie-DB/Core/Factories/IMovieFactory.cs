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
        Person CreatePerson(string firstName, string lasttName, string job);

        //Movie CreateMovie(string name, ICollection<Category> categories, string year, string releaseDate, int rating, string synopsis,
        //    ICollection<Person> writers, ICollection<Person> directors, ICollection<Person> cast, decimal budget);

        Series CreateSeries(string name, int rating, bool ongoing, int numberOfSeasons, int episodesPerSeason);
    }
}
