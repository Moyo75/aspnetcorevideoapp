﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.Controllers
{
    [Route("company/[controller]/[action]")]
    public class EmployeeController : Controller
    {
        //[Route("[action]")]
        public ContentResult Name()
        {
            return Content("Jonas");
        }

        //[Route("[action]")]
        public string Country()
        {
            return "Nigeria";
        }

        //[Route("")]
        //[Route("[action]")]
        public string Index()
        {
            return "Hello, from Employee";
        }
    }
}
