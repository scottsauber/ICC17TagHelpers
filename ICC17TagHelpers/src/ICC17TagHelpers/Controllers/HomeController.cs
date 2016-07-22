using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ICC17TagHelpers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult HtmlHelpersTagHelpersShowdown() => View();
        public IActionResult BootstrapTagHelperSamples() => View();
        public IActionResult Error() => View();
    }
}
