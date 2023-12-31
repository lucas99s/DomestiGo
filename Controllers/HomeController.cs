﻿using DomestiGo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DomestiGo.Controllers
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
            string user = HttpContext.Session.GetString("UserName");
            if (user != null)
            {
                ViewBag.userName = user;
            } 
            else
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }

        public IActionResult Profile()
        {
            string user = HttpContext.Session.GetString("UserName");
            if (user != null)
            {
                ViewBag.userName = user;
                ViewBag.initial = user[0];
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
