﻿using Microsoft.AspNetCore.Mvc;

namespace WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashbaordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
