using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Framework;
using Ninject;
using Bytes2you.Validation;

namespace Movie_DB.Commands.Core.Factories
{
    public class CommandFactory : ICommandFactory
    {
        public Person CreatePerson(string commandParams)
        {
            throw new NotImplementedException();
        }


        private readonly IKernel kernel;

        public CommandFactory(IKernel kernel)
        {
            Guard.WhenArgument(kernel, "kernel").IsNull().Throw();

            this.kernel = kernel;
        }

        public ICommand CreateCommand(string commandName)
        {
            return this.kernel.Get<ICommand>(commandName);
        }
    }
}
