using System.ComponentModel.DataAnnotations;

namespace EfCore_Sample.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public Person(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}
