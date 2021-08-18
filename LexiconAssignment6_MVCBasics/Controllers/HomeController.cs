using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconAssignment6_MVCBasics.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult About()
        {
            ViewBag.Name = "Muzdalifa Ali";
            ViewBag.Info =  "I am a junior software developer and a data analyst with working" +
                 " experience in C# and python. I am passionate about the latest cutting-edge" +
                 " developmenttechnologies and procedures. I am able to effectively self-manage" +
                 " during independent tasks, as well as collaborating as part of a productive team. ";
            ViewBag.Experience1 = " DATA ANALYSTS – SIMUMATIK AB, Skövde";
            ViewBag.Experience1Time =  "SEP 2019 – FEB 2020 ";
            ViewBag.Education1 = "PROGRAMMERING.NET – Lexicon Yrkesutbilding i Väst ";
            ViewBag.Education1Time = "8 JUN 2021 – CURRENT ";

            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }
    }
}
