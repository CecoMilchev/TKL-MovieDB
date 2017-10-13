using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Framework
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Year { get; set; }

        public string ReleaseDate { get; set; }

        public decimal Budget { get; set; }

        public ICollection<Person> Writers { get; set; }

        public ICollection<Person> Actors { get; set; }

        public ICollection<Person> Directors { get; set; }

        public ICollection<Category> Categories { get; set; }

        public int Rating { get; set; }

        public string Synopsis { get; set; }

        public string PlotDescription { get; set; }

    }
}
