﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorldWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // This is the main action
            return View();
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

        public ActionResult Sample()
        {
            ViewBag.Message = "This is a sample page.";

            return View();
        }
    }
}