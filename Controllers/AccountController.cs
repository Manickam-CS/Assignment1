using Assignment1.BusinessLogic;
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Controllers
{
    public class AccountController : Controller
    {       
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                ViewBag.ValidationMessage = "Registration Success!";
            }
            else
            {
                ViewBag.ValidationMessage = "Registration Failed!";
            }
            return View();
        }
    }
}
