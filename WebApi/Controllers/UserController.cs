﻿using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
