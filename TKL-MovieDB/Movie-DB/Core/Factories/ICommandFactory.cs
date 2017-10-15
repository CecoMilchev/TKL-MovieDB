using Models.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Movie_DB.Commands.Core.Factories
{
    public interface ICommandFactory
    {
        ICommand CreateCommand(string commandChoice);
    }
}
