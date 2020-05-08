using System;
using Microsoft.AspNetCore.Mvc;

namespace Sqrt_of_numbers.Controllers
{
    public class CalcController : Controller
    {
        [HttpGet]
        public ActionResult Sqrt()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Sqrt(string firstNum, string secNum)
        {

            int num1 = int.Parse(firstNum);
            int num2 = int.Parse(secNum);
            ViewBag.num1 = num1;
            ViewBag.num2 = num2;

            double result1 = Math.Sqrt(num1);
            double result2 = Math.Sqrt(num2);

            ViewBag.Result1 = result1;
            ViewBag.Result2 = result2;

            if (ViewBag.Result1 is null || ViewBag.Result2 is null)
            {
                ViewBag.ErrorMessage = "Invalid Numbers entered!";
            }
            else if (ViewBag.num1 < 0 || ViewBag.num2 < 0)
            {
                ViewBag.NegMessage = "Oops! You inputed a negative integer, Enter another set of numbers!";
            }
            else if (ViewBag.Result1 == ViewBag.Result2 )
            {
                ViewBag.AlikeMessage = "The numbers have the same SqareRoot, Enter another set of numbers!";
            }
            return View();
        }
    }
}
