namespace EfCore_Sample.Models
{
    public class PersonInformation
    {
        public int PersonInfoId { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
