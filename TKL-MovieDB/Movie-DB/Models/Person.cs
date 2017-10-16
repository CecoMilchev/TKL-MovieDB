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

        public override string ToString()
        {
            return string.Format(@"
|| First Name: {0}
|| Last Name: {1}
|| Job: {2}
",this.FirstName, this.LastName, this.Job);
        }
    }
}
