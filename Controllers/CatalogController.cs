
using Microsoft.AspNetCore.Mvc;
using Property_Rental.Models;
using System.Linq;

namespace Property_Rental.Controllers
{
    public class CatalogController : Controller
    {
        private DataContext dbContext;
        public CatalogController(DataContext db)
        {
            dbContext = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetProperties()
        {
            var data = dbContext.Properties.ToList(); //read all records from table
            return Json(data);
        }

        [HttpDelete]
        public IActionResult DeleteProperty(int id)
        {
            var theProperty = dbContext.Properties.Find(id);
            dbContext.Properties.Remove(theProperty);
            dbContext.SaveChanges();
            
            return Ok();
        }

        [HttpPost]
        public IActionResult SaveProperty( [FromBody] Property theProperty )
        {
            // store theProperty into DB
            dbContext.Properties.Add(theProperty);
            dbContext.SaveChanges();

            //temp
            return Json(theProperty);
        }
    }
}