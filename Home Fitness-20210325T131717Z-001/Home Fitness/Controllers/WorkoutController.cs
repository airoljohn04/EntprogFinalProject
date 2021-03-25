using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Home_Fitness.Data;
using Home_Fitness.Models;

namespace Home_Fitness.Controllers
{
    public class WorkoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EquipmentPage()
        {
            return View();
        }

        public IActionResult WorkoutPage()
        {
            return View();
        }
    }
}
