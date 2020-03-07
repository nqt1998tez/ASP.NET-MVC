using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMVC.Controllers
{
    public class BoostrapController : Controller
    {
        // GET: Boostrap
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult News()
        {
            return View();
        }
    }
}