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

        public virtual ICollection<Genre> Genres { get; set; }

        public virtual ICollection<Person> Creators { get; set; }

        public virtual ICollection<Person> Writers { get; set; }

        public virtual ICollection<Person> Actors { get; set; }

        public virtual ICollection<Person> Cast { get; set; }

        public string Ongoing { get; set; }

        public int NumberOfSeasons { get; set; }

        public int EpisodesPerSeason { get; set; }
    }
}
