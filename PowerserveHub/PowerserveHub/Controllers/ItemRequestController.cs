using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PowerserveHub.Controllers
{
    public class ItemRequestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}