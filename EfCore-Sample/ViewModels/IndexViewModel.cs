using EfCore_Sample.Models;

namespace EfCore_Sample.ViewModels
{
    public class IndexViewModel
    {
        public Person person { get; set; }
        public List<Person> people { get; set; }
    }
}
