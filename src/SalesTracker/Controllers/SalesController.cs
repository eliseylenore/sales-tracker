using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesTracker.Models;

namespace SalesTracker.Controllers
{
    public class SalesController : Controller
    {
        private SalesTrackerContext db = new SalesTrackerContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewSale(int id)
        {
            Car thisCar = db.Cars.FirstOrDefault(cars => cars.CarId == id);
            return View(thisCar);
        }

        [HttpPost]
        public IActionResult NewSale(decimal sellingPrice, string comment, int carId)
        {
            CarSale newSale = new CarSale(sellingPrice, comment, carId);
            db.CarSales.Add(newSale);
            db.SaveChanges();
            return Json(newSale);
        }
    }

  
}
