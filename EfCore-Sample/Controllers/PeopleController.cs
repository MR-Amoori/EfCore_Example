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

        public IActionResult AddPerson(Person person)
        {
            if (!ModelState.IsValid)
            {
                return View(person);
            }

            if (_context.People.Any(p => p.UserName.ToLower() == person.UserName.ToLower()) == true)
            {
                return RedirectToActionPermanent("Index", "Home");
            }

            _context.People.Add(person);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}
