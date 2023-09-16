using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomestiGo.Models;

namespace DomestiGo.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View("Login");
        }

        public IActionResult SignIn()
        {
            return View("SignIn");
        }

        [HttpPost]
        public IActionResult SignIn(UserModel user)
        {
            using(var db = new DomestiGoContext())
            {
                db.Add(user);
                db.SaveChanges();
            }

            return View("SignIn");
        }

        [HttpPost]
        public IActionResult Login(UserModel user)
        {
            using (var db = new DomestiGoContext())
            {
                var existingUser = db.Users.FirstOrDefault(u => u.Email == user.Email);

                if (existingUser != null)
                {
                    var password = db.Users.FirstOrDefault(u => u.Password == user.Password);
                    if(password != null)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            return View();
        }

    }
}
