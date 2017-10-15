using Bytes2you.Validation;
using Movie_DB.Commands.Contracts;
using Movie_DB.Commands.Core.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DB.Commands.Creating
{
    public class CreatePersonCommand : ICommand
    {
        private readonly ITravellerContext context;
        //private readonly IDatabase database;
        private readonly IMovieFactory factory;

        public CreatePersonCommand(ITravellerContext context, IDatabase database, IMovieFactory factory)
        {
            Guard.WhenArgument(context, "context").IsNull().Throw();
            Guard.WhenArgument(database, "database").IsNull().Throw();
            Guard.WhenArgument(factory, "factory").IsNull().Throw();

            this.context = context;
            this.database = database;
            this.factory = factory;
        }

        public string Execute(IList<string> parameters)
        {
            throw new NotImplementedException();
        }
    }
}
