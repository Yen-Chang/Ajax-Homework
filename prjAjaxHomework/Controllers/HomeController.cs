﻿using Microsoft.AspNetCore.Mvc;
using prjAjaxHomework.Models;
using System.Diagnostics;

namespace prjAjaxHomework.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Homework1()
        {
            return View();
        }        
        
        public IActionResult Homework2()
        {
            return View();
        }

        public IActionResult Travel()
        {
            return View();
        }

        public IActionResult Homework3()
        {
            return View();
        }
        public IActionResult Homework4()
        {
            return View();
        }

        public IActionResult Address()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}