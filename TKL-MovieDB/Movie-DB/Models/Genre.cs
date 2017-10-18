using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Models.Framework
{
    public class Genre
    {
        public Genre()
        {
        }

        public int Id { get; set; }

        [Required]
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
