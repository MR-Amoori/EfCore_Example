using System.ComponentModel.DataAnnotations;

namespace EfCore_Sample.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(5)]
        public string? UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MaxLength(10)]
        [MinLength(8)]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$")]
        public string? Password { get; set; }

    }
}
