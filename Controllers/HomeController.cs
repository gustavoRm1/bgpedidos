﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc.Models;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {

  
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Produtos()
        {
            return View();
        }
         
        public IActionResult Sobre()
        {
            return View();
        }
        public IActionResult AcessoNegado()
        {
            return View();
        }
         
          
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    };
}
