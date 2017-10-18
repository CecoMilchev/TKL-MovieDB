using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [JsonProperty("username")]
        public string Username { get; set; }

        [Required]
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [Required]
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("watchList")]
        public virtual ICollection<Movie> WatchList { get; set; }

        [JsonProperty("myRatings")]
        public virtual ICollection<Movie> MyRatings { get; set; }

        [JsonProperty("favoriteMovies")]
        public virtual ICollection<Movie> FavoriteMovies { get; set; }

        [JsonProperty("favoriteSeries")]
        public virtual ICollection<Series> FavoriteSeries { get; set; }

        [JsonProperty("favoriteActors")]
        public virtual ICollection<Person> FavoriteActors { get; set; }
    }
}
