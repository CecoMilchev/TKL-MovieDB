using Bytes2you.Validation;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Framework
{
    [NotMapped]
    public class Movie
    {
        private ICollection<Genre> genres;
        private ICollection<Person> writers;
        private ICollection<Person> directors;
        private ICollection<Person> cast;

        public Movie()
        {
            this.genres = new HashSet<Genre>();
            this.writers = new HashSet<Person>();
            this.directors = new HashSet<Person>();
            this.cast = new HashSet<Person>();
        }
        

        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "The Name's length cannot be less than 5 or more than 50 symbols long.")]
        public string Title { get; set; }

        [Required]
        public virtual ICollection<Genre> Genres { get; set; }

        public string Year { get; set; }

        public string ReleaseDate { get; set; }

        public int Rating { get; set; }

        [Required]
        [StringLength(300, MinimumLength = 3, ErrorMessage = "The Movie's Synopsis' length cannot be less than 80 or more than 300 symbols long.")]

        public string Synopsis { get; set; }

        public virtual ICollection<Person> Writers { get; set; }

        public virtual ICollection<Person> Directors { get; set; }

        public virtual ICollection<Person> Cast { get; set; }

        public decimal Budget { get; set; }
    }
}
