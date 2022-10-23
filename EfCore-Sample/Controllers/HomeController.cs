using EfCore_Sample.Context;
using EfCore_Sample.Models;
using EfCore_Sample.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EfCore_Sample.Controllers
{
    public class HomeController : Controller
    {
        private readonly EfCoreContext _context;

        public HomeController(EfCoreContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IndexViewModel model = new();

            model.people = _context.People.ToList();

            // Update All Data 
            // var personForSample = _context.People.ToList();
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