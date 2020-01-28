using netFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace netFramework.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        //public ViewResult for saving casting in the unit testing
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "shrek!" };
            return View(movie);
            //return new ViewResult();
            //return Content("Hello Wolrd!");
            //return HttpNotFound();
                                                     // anonymous object for adding params to url as query string (e.g ?<key>=<value>&<key>=<value>)
            //return RedirectToAction("index", "Home", new { page = 1, sortBy = "name" });

            //for creating a action that doesnt return anything
            //return new EmptyResult();
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue) pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy)) sortBy = "name";

            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}