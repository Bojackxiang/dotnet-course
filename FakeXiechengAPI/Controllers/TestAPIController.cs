using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace FakeXiechengAPI.Controllers
{
    // 访问: https://localhost:5001/api/testapi
    [Route("/api/[controller]")]
    public class TestAPIController : Controller
    {
        // GET
        [HttpGet]
        public IEnumerable<string> Index()
        {
            Console.WriteLine("test controller");
            // return View();
            return new[] {"1", "2"};
        }

        [HttpGet("{id}")]
        public string Index(int Id)
        {
            Console.WriteLine("test controller");
            // return View();
            return "string";
        }
    }
}