using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Framework;
using Movie_DB.Migrations;

namespace Movie_DB.Data
{
    public class MovieDbContext : DbContext, IMovieDbContext
    {
        public MovieDbContext()
            : base("MovieDbConnection")
        {
        }

        //public IDbSet<Movie> Movies { get; set; }
        // public IDbSet<User> Users { get; set; }
        public IDbSet<Person> Persons { get; set; }
        public IDbSet<Genre> Genres { get; set; }
        //public IDbSet<Series> SeriesCollection { get; set; }


    }
}
