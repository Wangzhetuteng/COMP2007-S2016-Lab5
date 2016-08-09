﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COMP2007_S2016_Lab5.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ViewResult Index()
        {
            return View("Error");
        }
        // GET: NotFound 
        public ViewResult NotFound()
        {
            Response.StatusCode = 404;

            return View("NotFound");
        }
    }
}