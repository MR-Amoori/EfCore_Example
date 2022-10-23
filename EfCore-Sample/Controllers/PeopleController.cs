using EfCore_Sample.Models;
using EfCore_Sample.Repositories.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EfCore_Sample.Controllers
{
    public class PeopleController : Controller
    {
        private readonly IPeopleRepository _repository;

        public PeopleController(IPeopleRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult AddPerson(Person person)
        {
            if (!ModelState.IsValid)
            {
                return View(person);
            }

            if (_repository.HasPeople(person.Id))
            {
                return RedirectToActionPermanent("Index", "Home");
            }

            _repository.AddPerson(person);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult DeletePerson(int id)
        {
            if (_repository.HasPeople(id))
            {
                _repository.DeletePeople(id);
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult EditPerson(int id)
        {
            if (_repository.HasPeople(id))
            {
                return View(_repository.GetById(id));
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

            _repository.UpdatePeople(person);

            return RedirectToAction("Index", "Home");
        }
    }
}