using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestAspCoreApp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("https://metanit.com/sharp/aspnet5/20.1.php");
        }
    }
}