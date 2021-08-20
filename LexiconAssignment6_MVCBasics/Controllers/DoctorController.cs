using LexiconAssignment6_MVCBasics.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconAssignment6_MVCBasics.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index(float temperature)
        {
            if(temperature != 0)
            {
                ViewBag.Message = Utility.CheckFever(temperature);
            }            
            return View();
        }
    }
}
