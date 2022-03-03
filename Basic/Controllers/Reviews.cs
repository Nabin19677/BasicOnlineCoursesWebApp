using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Controllers
{
    public class Reviews : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
