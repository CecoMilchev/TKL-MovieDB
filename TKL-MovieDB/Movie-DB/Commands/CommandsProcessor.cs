using Movie_DB.Commands.Contracts;
using Movie_DB.Commands.Core.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DB.Commands
{
    public class CommandsProcessor : ICommandProcessor
    {
        private readonly ICommandFactory commandFactory;

        public CommandsProcessor(ICommandFactory commandFactory)
        {
            this.commandFactory = commandFactory;
        }
        public void ProcessCommand(string commandNumber) {
            Console.WriteLine("processor called");
          var command =  this.commandFactory.CreateCommand(commandNumber);
            command.Execute();
        }

    }
}
