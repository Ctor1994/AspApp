using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using tHISiStHEsHOP.Models;

namespace tHISiStHEsHOP.Controllers
{
    public class HomeController : Controller
    {
        //[Authorize(Roles = "user")]
        public IActionResult Index()
        {
            //string role = User.FindFirst(x => x.Type == ClaimsIdentity.DefaultRoleClaimType).Value;
            //return Content($"ваша роль: {role}");
            return View();
        }
        [Authorize(Roles = "user")]
        public IActionResult About()
        {
            return Content("Вход только для зарегистрированного пользователя");
        }
    }
}
