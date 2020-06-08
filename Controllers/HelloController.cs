﻿
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWeb.Controllers
{
    public class HelloController : Controller
    {


        public IActionResult Welcome(string name = "Vreemdeling", int numberOfTimes = 1)
        {
            ViewData["Name"] = name;
            ViewData["NumberOfTimes"] = numberOfTimes;
            return View();
        }



        //public string Welcome(string name = "Vreemdeling", int numberOfTimes = 1)
        //{
        //    string message = " ";

        //    for(int i = 0; i<numberOfTimes; i++)
        //    {
        //        message += "Hallo" + name + "! ";
        //    }

        //    return message;
        //}

    }
}

