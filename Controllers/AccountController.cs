using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomestiGo.Models;
using Microsoft.AspNetCore.Http;

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
            bool newRegistration = TempData.ContainsKey("NewRegistration") && (bool)TempData["NewRegistration"];
            if(newRegistration)
            {
                ViewBag.NewRegistration = "Usuário cadastrado com sucesso!";
            }

            TempData.Remove("NewRegistration");
            return View("Login");
        }

        public IActionResult SignIn()
        {
            return View("SignIn");
        }

        [HttpPost]
        public IActionResult SignIn(UserModel user)
        {
            using (var db = new DomestiGoContext())
            {
                var existingUser = db.Users.FirstOrDefault(u => u.Email == user.Email);
                if (existingUser == null)
                {
                    if (user.Password == user.PasswordConfirmation)
                    {

                        var newUser = new UserDb
                        {
                            Name = user.Name,
                            SurName = user.SurName,
                            Email = user.Email,
                            Password = user.Password
                        };

                        db.Add(newUser);
                        db.SaveChanges();

                        TempData["NewRegistration"] = true;
                        return RedirectToAction("Login", "Account");
                    } 
                    else
                    {
                        ViewBag.PasswordMessage = "Senhas não são iguais!";
                    }
                }
                else
                {
                    ViewBag.UserMessage = "E-mail já cadastrado!";
                }

            }

            return View();
        }

        [HttpPost]
        public IActionResult Login(UserModel user)
        {
            using (var db = new DomestiGoContext())
            {
                var existingUser = db.Users.FirstOrDefault(u => u.Email == user.Email);

                if (existingUser != null)
                {
                    if(existingUser.Password == user.Password)
                    {
                        HttpContext.Session.SetString("UserName", existingUser.Name);
                        return RedirectToAction("Index", "Home");
                    } 
                    else
                    {
                        ViewBag.PasswordMessage = "Senha inválida!";
                    }
                    
                } 
                else
                {
                    ViewBag.EmailMessage = "Usuário inválido!";
                }
            }
            return View();
        }

    }
}
