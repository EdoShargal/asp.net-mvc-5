using netFramework.Models;
using netFramework.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace netFramework.Controllers
{
    public class ViewDataController : Controller
    {
        // GET: ViewData/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"},
                new Customer { Name = "Customer 3"},
                new Customer { Name = "Customer 4"},
                new Customer { Name = "Customer 5"},
                new Customer { Name = "Customer 6"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
          
                //Customers = new List<Customer>()
            };

            //ViewData["Movie"] = movie;
            //ViewBag.Movie = movie;

            //example
            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model


            return View(viewModel);
        }
    }
}