﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// This code prints hello world .
        /// </summary>
        /// <returns>Hello World</returns>

        //Post api/Greeting
        public string Post()
        {
            return "Hello World!";
        }
    }
}
