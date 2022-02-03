using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FilmCollector.Models;

namespace FilmCollector.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private FilmCollectionContext _filmAdder { get; set; }

        public HomeController(ILogger<HomeController> logger, FilmCollectionContext someName )
        {
            _logger = logger;
            _filmAdder = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddtoCollection()
        {
            return View();
        }

        [HttpPost]
        //cr = what being passed from the form
        public IActionResult AddtoCollection(CollectionResponse cr)
        {
            if (ModelState.IsValid)
            {
                //get data from form
                _filmAdder.Add(cr);
                //save changes
                _filmAdder.SaveChanges();

                return View("Index");
            }
            else
            {
                return View(cr);
            }

        }

    }
}
