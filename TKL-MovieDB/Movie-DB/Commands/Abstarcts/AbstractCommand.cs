using Movie_DB.Commands.Core.Factories;
using Movie_DB.Core.Providers;
using Movie_DB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DB.Commands.Abstarcts
{
    public abstract class AbstractCommand
    {
        private readonly IMovieFactory factory;
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IMovieDbContext context;

        public AbstractCommand(MovieDbContext context, IMovieFactory factory, IReader reader, IWriter writer)
        {
            this.context = context;
            this.factory = factory;
            this.reader = reader;
            this.writer = writer;
        }
    }
}
