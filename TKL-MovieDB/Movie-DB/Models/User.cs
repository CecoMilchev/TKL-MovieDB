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
        public User()
        {
                
        }

        [Required]
        public string Username { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public ICollection<Movie> WatchList { get; set; }

        public ICollection<Movie> MyRatings { get; set; }

        public ICollection<Movie> Favorites { get; set; }

        public ICollection<Person> FavoriteActors { get; set; }
    }
}
