using IS413Assignment5Real.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using IS413Assignment5Real.Models.ViewModels;

namespace IS413Assignment5Real.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //makes private repository of type ibooks
        private IBooksRepository _repository;
        // determine number of items per page
        public int NumPages = 5;

        public HomeController(ILogger<HomeController> logger,IBooksRepository repository)
        {
            // home controller constructor guy has attribute _repository which is repository
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index(int page = 1)
        {
            if (ModelState.IsValid)
            {
                // puts the list guy in sets
                return View(new BookListViewModel
                {
                    // setbooks
                    Books = _repository.Books.OrderBy(b => b.Price).Skip((page - 1) * NumPages).Take(NumPages),
                    PagingInfo = new PagingInfo
                    {
                        CurrentPage = page,
                        ItemsPerPage = NumPages,
                        TotalItems = _repository.Books.Count()
                    }

                }) ;

                   
            }
            else
            {
                return View();
            }
        }

        public IActionResult BookList()
        {
            return View();
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
