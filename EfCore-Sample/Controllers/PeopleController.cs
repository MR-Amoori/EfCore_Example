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

        public IActionResult DeletePerson(int Id)
        {
            if (_context.People.Any(p => p.Id == Id))
            {
                var person = _context.People.FirstOrDefault(p => p.Id == Id);
                _context.People.Remove(person);
                _context.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult EditPerson(int Id)
        {
            if (_context.People.Any(p => p.Id == Id))
            {
                Person? person = _context.People.FirstOrDefault(p => p.Id == Id);
                return View(person);
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult EditPerson(Person person)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("UserName", "This username exists !");
                return View(person);
            }

            _context.People.Update(person);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}