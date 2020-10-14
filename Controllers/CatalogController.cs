
using Microsoft.AspNetCore.Mvc;
using Property_Rental.Models;

namespace Property_Rental.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SaveProperty( [FromBody] Property theProperty )
        {
            //store theProperty into DB
            System.Console.WriteLine("Saving the property");
            System.Console.WriteLine(theProperty.Title);

            //temp
            theProperty.Id = 1;
            return Json(theProperty);
        }
    }
}