using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconAssignment6_MVCBasics.Controllers
{
    public class GuessingGameController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("attempt") == null)
            {
                //count the number of guessing
                HttpContext.Session.SetInt32("attempt", 0);
                

                int randomNum = new Random().Next(1, 101);
                HttpContext.Session.SetInt32("guess", randomNum);
            }

            return View();
        }

        [HttpPost]
        public IActionResult Index(int number)
        {
            int guessNumber = Convert.ToInt32(HttpContext.Session.GetInt32("guess"));
            int? attempt = HttpContext.Session.GetInt32("attempt");

            if (attempt != null)
            {
                attempt = HttpContext.Session.GetInt32("attempt");
                attempt = attempt + 1;
                HttpContext.Session.SetInt32("attempt", Convert.ToInt32(attempt));
            }
            
            if (number > guessNumber)
            {
                ViewBag.Message = "Number is high ";
            }
            else if (number < guessNumber)
            {
                ViewBag.Message = "Number is low";
            }
            else
            {
                ViewBag.Message = $"You have tried {HttpContext.Session.GetInt32("attempt")} times. " +
                "Congratulation! You have guess the correct number!";
            }

            return View();
        }
    }
}
