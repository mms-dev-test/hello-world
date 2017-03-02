using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorldWebApp.Controllers
{
    public class CustomActionsController : Controller
    {
        // GET: CustomActions
        public ActionResult Index()
        {
            return View();
        }
    }
}