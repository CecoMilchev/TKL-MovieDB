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
    public class Category
    {
        public Category()
        {
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
