using Movie_DB.Commands.Contracts;
using Movie_DB.Core.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DB.Commands.Creating
{
    public class HelpCommand : ICommand
    {
        private StringBuilder commands = new StringBuilder();

        public void CollectData()
        {
            throw new NotImplementedException();
        }

        public string Execute()
        {
            commands.AppendLine("'Create Person' - creates a person");
            commands.AppendLine("'Exit' - exit the program");

            return commands.ToString();
        }
    }
}
