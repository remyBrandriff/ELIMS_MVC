﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ELIMS_MVC.Controllers
{
    public class LabController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}