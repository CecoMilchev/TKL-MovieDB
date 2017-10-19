using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models.Framework
{
    public class Person
    {
        private ICollection<Movie> movies;
        
        public Person()
        {
            this.movies = new HashSet<Movie>();
        }

        public int Id { get; set; }

        [Required]
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [Required]
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [Required]
        [JsonProperty("job")]
        public string Job { get; set; }


        public ICollection<Movie> Movies
        {
            get
            {
                return this.movies;
            }
            set
            {
                this.movies = value;
            }
        }

        public override string ToString()
        {
            return string.Format(@"
|| First Name: {0}
|| Last Name: {1}
|| Job: {2}
", this.FirstName, this.LastName, this.Job);
        }
    }
}
