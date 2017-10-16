using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Framework
{
    
    [NotMapped]
    public class Series
    {
        public int ID { get; set; }
        
        public string Name { get; set; }

       // public int Rating { get; set; }

        public ICollection<Category> Categories { get; set; }

        public ICollection<Person> Creators { get; set; }

        public ICollection<Person> Writers { get; set; }

        public ICollection<Person> Actors { get; set; }

        public ICollection<Person> Cast { get; set; }

        public bool Ongoing { get; set; }

        public int NumberOfSeasons { get; set; }

        public int EpisodesPerSeason { get; set; }
    }
}
