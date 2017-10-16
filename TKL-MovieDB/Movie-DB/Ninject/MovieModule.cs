using Movie_DB.Commands;
using Movie_DB.Commands.Contracts;
using Movie_DB.Commands.Core.Factories;
using Movie_DB.Commands.Creating;
using Movie_DB.Core.Providers;
using Movie_DB.Data;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DB.Ninject
{
    public class MovieModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IMovieDbContext>().To<MovieDbContext>();
            this.Bind<IReader>().To<ConsoleReader>();
            this.Bind<IWriter>().To<ConsoleWriter>();
            this.Bind<ICommandProcessor>().To<CommandsProcessor>();

            this.Bind<IMovieFactory>().To<MovieFactory>();
            this.Bind<ICommandFactory>().To<CommandFactory>();
            this.Bind<ICommand>().To<CreatePersonCommand>().Named("CreatePersonCommand");
            //this.Bind<ICommand>().To<CreateMovieCommand>().Named("CreateMovieCommand");
        }
    }
}
