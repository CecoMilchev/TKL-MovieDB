using Bytes2you.Validation;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Framework
{
    [NotMapped]
    public class Movie
    {
        private ICollection<Genre> categories;
        private ICollection<Person> writers;
        private ICollection<Person> directors;
        private ICollection<Person> cast;

        public Movie()
        {
            this.categories = new HashSet<Genre>();
            this.writers = new HashSet<Person>();
            this.directors = new HashSet<Person>();
            this.cast = new HashSet<Person>();
        }

        public Movie(string name, ICollection<Genre> categories, string year, string releaseDate, int rating, string synopsis,
            ICollection<Person> writers, ICollection<Person> directors, ICollection<Person> cast, decimal budget)
        {
            this.Name = name;
            this.Categories = new HashSet<Genre>();
            this.Year = year;
            this.ReleaseDate = releaseDate;
            this.Rating = rating;
            this.Synopsis = synopsis;
            this.writers = new HashSet<Person>();
            this.directors = new HashSet<Person>();
            this.cast = new HashSet<Person>();
            this.Budget = budget;
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "The Name's length cannot be less than 5 or more than 50 symbols long.")]
        public string Name { get; set; }

        [Required]
        public ICollection<Genre> Categories { get; set; }

        public string Year { get; set; }

        public string ReleaseDate { get; set; }

        public int Rating { get; set; }

        [Required]
        [StringLength(300, MinimumLength = 3, ErrorMessage = "The Movie's Synopsis' length cannot be less than 80 or more than 300 symbols long.")]

        public string Synopsis { get; set; }

        public ICollection<Person> Writers { get; set; }

        public ICollection<Person> Directors { get; set; }

        public ICollection<Person> Cast { get; set; }

        public decimal Budget { get; set; }
    }
}
