﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVC.Models;

namespace TestMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new myclass
            {
                title = "title",
                body = "body"
            };
            return View(model);
        }
        [ChildActionOnly]
        public ActionResult ChildAction()
        {
            var model = new myclass
            {
                title = "ChildAction:title",
                body = "ChildAction:body"
            };
            return View(model);
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