using EfCore_Sample.Models;
using EfCore_Sample.Repositories.Repository;
using EfCore_Sample.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EfCore_Sample.Controllers
{
    public class HomeController : Controller
    {

        private readonly IPeopleRepository _repository;

        public HomeController(IPeopleRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            IndexViewModel model = new();

            model.people = _repository.GetPeople();

            // Update All Data 
            // var personForSample = _repository.GetPeople();
            // personForSample.ForEach(p => p.Password = "Mohamad021_@");

            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}