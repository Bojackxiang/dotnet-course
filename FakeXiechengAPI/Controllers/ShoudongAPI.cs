using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace FakeXiechengAPI.Controllers
{
    [Route("api/shoudongapi")]
    // [Controller]
    // public class ShoudongAPI
    public class ShoudongAPI : Controller
        // public class ShoudongAPIController
    {
        // GET
        [HttpGet]
        public IEnumerable<string> Index()
        {
            Console.WriteLine("test controller");
            // return View();
            return new[] {"1", "2"};
        }
    }
}