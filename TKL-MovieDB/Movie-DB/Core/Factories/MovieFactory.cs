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

        public Movie CreateMovie(string name, ICollection<Category> categories, string year, string releaseDate, int rating, string synopsis,
            ICollection<Person> writers, ICollection<Person> directors, ICollection<Person> cast, decimal budget)
        {
            Movie movie = new Movie()
            {
                //Name = name;
                //Categories = categories;
                //Year = year;
            };

        }
    }
}



