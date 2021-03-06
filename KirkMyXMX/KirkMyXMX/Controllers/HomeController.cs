﻿using KirkMyXMX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KirkMyXMX.Controllers
{
    public class HomeController : Controller
    {
        MainClass MyClass = new MainClass();
        
        public ActionResult Index()
        {
            
            return View(MyClass);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}