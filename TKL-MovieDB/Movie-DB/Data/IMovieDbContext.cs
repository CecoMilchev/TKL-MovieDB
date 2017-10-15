using Models.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DB.Data
{
    public interface IMovieDbContext
    {
        IDbSet<Movie> Movies { get; set; }
        IDbSet<User> Users { get; set; }
        IDbSet<Person> Persons { get; set; }
        IDbSet<Series> SeriesCollection { get; set; }

        int SaveChanges();
    }
}
