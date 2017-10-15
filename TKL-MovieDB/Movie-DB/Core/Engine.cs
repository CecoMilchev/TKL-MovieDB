using Movie_DB.Commands.Contracts;
using Movie_DB.Core.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DB.Core
{
    public class Engine : IEngine
    {
        public readonly IReader reader;
        public readonly IWriter writer;
        public readonly ICommandProcessor commandProcessor;

        public Engine(IReader reader, IWriter writer, ICommandProcessor commandProcessor)
        {
            this.reader = reader;
            this.writer = writer;
            this.commandProcessor = commandProcessor;
        }
        
        public void Start()
        {
            writer.WriteLine("Welcome to TKL-MovieDB");
            writer.WriteLine("");
            writer.WriteLine("What do you want to do?");
            writer.WriteLine("For CreatePerson press 1");

           string commandChoice = reader.ReadLine();

            commandProcessor.ProcessCommand(commandChoice);

        }
    }
}
