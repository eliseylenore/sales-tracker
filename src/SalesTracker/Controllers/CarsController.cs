using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesTracker.Models;



namespace SalesTracker.Controllers
{
    
    public class CarsController : Controller
    {
        private SalesTrackerContext db = new SalesTrackerContext();

        public IActionResult Index()
        {
            return View(db.Cars.ToList());
        }

        public IActionResult DisplayViewWithAjax()
        {
            return View(db.Cars.ToList());
        }

        [HttpPost]
        public IActionResult NewCar(string newMake, string newModel, string newYear, decimal newPrice, string newDescription)
        {
            Car newCar = new Car(newMake, newModel, newYear, newPrice, newDescription);
            db.Cars.Add(newCar);
            db.SaveChanges();
            return Json(newCar);

        }
    }
}
