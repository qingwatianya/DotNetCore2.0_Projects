﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetCore2_Web_Aplication_HangFire.Models;
using Hangfire;

namespace DotNetCore2_Web_Aplication_HangFire.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public string CreateJob()
        {
            
            //RecurringJob.AddOrUpdate(() => Console.WriteLine("香菇蓝瘦"), Cron.Minutely());
            //RecurringJob.AddOrUpdate(() => HAHA(), Cron.Minutely());
            //RecurringJob.AddOrUpdate(() => DotNetFrameWork_Library.Class1.FuckStatic(), Cron.Minutely());
            return "What the fuck!";
        }

        public static void HAHA()
        {

        }
    }
}
