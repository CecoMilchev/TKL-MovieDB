﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Framework;
using Ninject;
using Bytes2you.Validation;
using Movie_DB.Commands.Contracts;
using Movie_DB.Ninject;

namespace Movie_DB.Commands.Core.Factories
{
    public class CommandFactory : ICommandFactory
    {

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
