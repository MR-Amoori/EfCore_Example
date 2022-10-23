using EfCore_Sample.Models;

namespace EfCore_Sample.Repositories.Repository
{
    public interface IPeopleRepository
    {
        // CRUD : Creat , Read , Update (Modify) , Delete

        public bool AddPerson(Person person);

        public List<Person> GetPeople();
        public Person GetById(int id);
        public bool HasPeople(int id);

        public bool UpdatePeople(Person person);

        public bool DeletePeople(int id);
        public bool DeletePeople(Person person);

    }
}
