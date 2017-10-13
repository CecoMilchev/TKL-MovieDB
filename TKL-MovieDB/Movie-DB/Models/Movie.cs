using System.Collections.Generic;

namespace Models.Framework
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Rating { get; set; }

        public ICollection<Category> Categories { get; set; }

        public string Year { get; set; }

        public string ReleaseDate { get; set; }

        public string Synopsis { get; set; }

        public ICollection<Person> Writers { get; set; }

        public ICollection<Person> Directors { get; set; }

        public ICollection<Person> Actors { get; set; }

        public ICollection<Person> Cast { get; set; }

        public decimal Budget { get; set; }
    }
}
