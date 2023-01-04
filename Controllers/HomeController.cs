using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using products_categories.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace products_categories.Controllers
{
    public class HomeController : Controller 
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }


        //GET PRODUCTS PAGE WITH NEW PRODUCT FORM
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Products");
        }


        



        [HttpGet("/categories")]
        public IActionResult Categories()
        {
            return View("Categories");
        }
    }
}
