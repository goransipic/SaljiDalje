﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Nop.Web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}