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
    }
}
