﻿namespace EfCore_Sample.Models
{
    // [Table("People" , Schema = "Shop")]
    public class Person
    {
        // [Key]
        public int Id { get; set; }

        //  [Required]
        //  [MaxLength(20)]
        //  [MinLength(5)]
        public string? UserName { get; set; }

        //  [Required]
        //  [DataType(DataType.Password)]
        //  [MaxLength(10)]
        //  [MinLength(8)]
        //  [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "8 Char - A-z - 0-9")]
        public string? Password { get; set; }

        public bool IsDeleted { get; set; }
    }
}
