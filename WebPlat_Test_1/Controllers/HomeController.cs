﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebPlat_Test_1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 首页模板
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult AdminDesktopTemp()
        {
            return View();
        }
    }
}