﻿using System;
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
    }
}
