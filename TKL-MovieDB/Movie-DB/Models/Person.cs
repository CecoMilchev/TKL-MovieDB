using System.ComponentModel.DataAnnotations;

namespace Models.Framework
{
    public class Person
    {
        public Person()
        {

        }

        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Job { get; set; }
    }
}
