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
    }
}
