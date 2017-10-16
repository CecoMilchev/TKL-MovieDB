using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Framework
{
    [NotMapped]
    public class Genre
    {
        public Genre()
        {
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
