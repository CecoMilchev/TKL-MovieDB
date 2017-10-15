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
        public void ProcessCommand(string commandNumber, ICommandFactory commandFactory)
        {
            switch (commandNumber)
            {
                case "1":
                   // commandFactory.
                    break;
            }
        }

    }
}
