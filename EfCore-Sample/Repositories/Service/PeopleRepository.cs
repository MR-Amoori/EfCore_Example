using EfCore_Sample.Context;
using EfCore_Sample.Models;
using EfCore_Sample.Repositories.Repository;

namespace EfCore_Sample.Repositories.Service
{
    public class PeopleRepository : IPeopleRepository
    {
        private readonly EfCoreContext _context;

        public PeopleRepository(EfCoreContext context)
        {
            _context = context;
        }

        public bool AddPerson(Person person)
        {
            try
            {
                _context.People.Add(person);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeletePeople(int id)
        {
            return DeletePeople(GetById(id));
        }

        public bool DeletePeople(Person person)
        {
            try
            {
                // Physical Delete:
                // _context.People.Remove(person);
                // _context.SaveChanges();

                // Logical Delete
                var personForDelete = GetById(person.Id);
                if (HasPeople(personForDelete.Id))
                {
                    personForDelete.IsDeleted = true;
                    _context.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Person GetById(int id)
        {
            return _context.People.Where(p => p.IsDeleted == false).FirstOrDefault(p => p.Id == id);
        }

        public List<Person> GetPeople()
        {
            return _context.People.Where(p => p.IsDeleted == false).ToList();
        }

        public bool HasPeople(int id)
        {
            return _context.People != null && _context.People.Any(p => p.Id == id);
        }

        public bool UpdatePeople(Person person)
        {
            try
            {
                _context.People.Update(person);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
