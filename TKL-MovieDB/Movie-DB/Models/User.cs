using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Framework
{
    [NotMapped]
    public class User
    {
        private ICollection<Movie> watchList;
        private ICollection<Movie> myRatings;
        private ICollection<Movie> favouriteMovies;
        private ICollection<Series> favouriteSeries;
        private ICollection<Person> favouriteActors;


        public User()
        {
            this.watchList = new HashSet<Movie>();
            this.myRatings = new HashSet<Movie>();
            this.favouriteMovies = new HashSet<Movie>();
            this.favouriteSeries = new HashSet<Series>();
            this.favouriteActors = new HashSet<Person>();

        }

        [Required]
        public string Username { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public virtual ICollection<Movie> WatchList { get; set; }

        public virtual ICollection<Movie> MyRatings { get; set; }

        public virtual ICollection<Movie> FavoriteMovies { get; set; }

        public virtual ICollection<Series> FavoriteSeries { get; set; }

        public virtual ICollection<Person> FavoriteActors { get; set; }
    }
}
