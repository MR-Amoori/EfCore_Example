namespace EfCore_Sample.Models
{
    #region DataAnotation
    // [Table("People" , Schema = "Shop")]
    #endregion
    public class Person
    {
        #region DataAnotation
        // [Key]
        #endregion
        public int Id { get; set; }
        #region DataAnotation
        //  [Required]
        //  [MaxLength(20)]
        //  [MinLength(5)]
        #endregion
        public string? UserName { get; set; }
        #region DataAnotation
        //  [Required]
        //  [DataType(DataType.Password)]
        //  [MaxLength(10)]
        //  [MinLength(8)]
        //  [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "8 Char - A-z - 0-9")]
        #endregion
        public string? Password { get; set; }
        public bool IsDeleted { get; set; }

        public PersonInformation PersonInformation { get; set; }
    }
}
