using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BartenderApplication.Models;

namespace BartenderApplication.Controllers
{
    public class HomeController : Controller
    {
        
        public ViewResult Index()
        {
            return View("Home");
        }

        [HttpGet]
        public ViewResult OrderNow()
        {
            return View();
        }

        [HttpPost]
        public ViewResult OrderNow(OrderNowData orderNowData)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(orderNowData);
                return View("OrderConfirmation", orderNowData);
            }
            else
            {
                return View();
            }
        }


        public ViewResult Menu()
        {
            return View();
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
