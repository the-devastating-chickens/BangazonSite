using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bangazon.Models;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Bangazon.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Bangazon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;

        }
        //Author: Rose
        //Date: 7/18/2019
        //Here we are using the .Take nethod to only grab 20 of the products. OrderByDescending let's us only grab the ones that have been most recently added.
        public IActionResult Index()
        {
            var applicationDbContext = _context.Product.Where(p => p.Active).OrderByDescending(p => p.DateCreated).Take(20);
            return View(applicationDbContext.ToList());
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
