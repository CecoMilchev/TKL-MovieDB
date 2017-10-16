using Movie_DB.Commands.Abstarcts;
using Movie_DB.Commands.Contracts;
using Movie_DB.Commands.Core.Factories;
using Movie_DB.Core.Providers;
using Movie_DB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DB.Commands.Creating
{
    public class CreateCategory : AbstractCommand, ICommand
    {
        private List<string> personData = new List<string>();

        public CreateCategory(MovieDbContext context, IMovieFactory factory, IReader reader, IWriter writer)
            : base(context, factory, reader, writer)
        {
        }
        public void CollectData()
        {
            throw new NotImplementedException();
        }

        public string Execute()
        {
            throw new NotImplementedException();
        }
    }
}
