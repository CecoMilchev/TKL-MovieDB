using Movie_DB.Commands.Core.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DB.Commands.Contracts
{
    public interface ICommandProcessor
    {
        void ProcessCommand(string commandNumber);
    }
}
