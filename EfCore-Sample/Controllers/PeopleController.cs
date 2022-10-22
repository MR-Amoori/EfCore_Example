using EfCore_Sample.Context;
using EfCore_Sample.Models;
using Microsoft.AspNetCore.Mvc;

namespace EfCore_Sample.Controllers
{
    public class PeopleController : Controller
    {
        EfCoreContext _context;

        public PeopleController(EfCoreContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddPerson(Person person)
        {
            if (person == null)
                return View(person);

            if (_context.People.Any(p => p.UserName == person.UserName) == true)
            {
                ModelState.AddModelError("Username", "This Username Exists !");
                return View(person);
            }

            _context.People.Add(person);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}
