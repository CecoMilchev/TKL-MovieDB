using Bytes2you.Validation;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models.Framework
{
    public class Movie
    {
        private string name;
        private int rating;
        private ICollection<Category> category;
        private string year;
        private string releaseDate;
        private string synopsis;
        private ICollection<Person> writers;
        private ICollection<Person> directors;
        private ICollection<Person> cast;
        private decimal budget;


        public Movie()
        {
        }

        //public Movie(string name, int rating, IEnumerable<Category> categories, string year, string releaseDate, string synopsis,
        //    IEnumerable<Person> writers, IEnumerable<Person> directors, IEnumerable<Person> cast, decimal budget)
        //{
        //    this.Name = name;
        //    this.Rating = rating;
        //    this.Year = year;
        //    this.ReleaseDate = releaseDate;
        //    this.Synopsis = synopsis;
        //    this.Writers = writers;
        //    this.Directors = directors;
        //    this.Cast = cast;
        //    this.Budget = budget;
        //}

        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "The Name's length cannot be less than 5 or more than 50 symbols long.")]
        public string Name { get; set; }


        public int Rating { get; set; }

        [Required]
        public ICollection<Category> Categories { get; set; }


        public string Year { get; set; }

        public string ReleaseDate { get; set; }

        [Required]
        [StringLength(300, MinimumLength = 80, ErrorMessage = "The Movie's Synopsis' length cannot be less than 80 or more than 300 symbols long.")]
        public string Synopsis { get; set; }

        public ICollection<Person> Writers { get; set; }

        public ICollection<Person> Directors { get; set; }

        //public ICollection<Person> Actors { get; set; }

        public ICollection<Person> Cast { get; set; }

        public decimal Budget { get; set; }
    }
}
