﻿using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class HomePage : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
