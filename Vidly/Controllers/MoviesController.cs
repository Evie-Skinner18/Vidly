using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Random()
        {
            // do not use ViewData or ViewBag
            // pass movie object to the view
            var shrek = new Movie() { Name = "Shrek" };
            var customers = new List<Customer>()
            {
                new Customer()
                {
                    Name = "Mr Edmund Blackadder",
                    Id = 1
                },
                new Customer()
                {
                    Name = "Mr S. Baldrick",
                    Id = 2
                }
            };

            return View(shrek);
        }

        // /movies GET all movies
        // pageIndex is nullable type so it's optional
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue) 
                pageIndex = 1;

            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(($"pageIndex={pageIndex}&sortBy={sortBy}"));
        }

        // EDIT this particular movie
        public ActionResult Edit(int id)
        {
            return Content($"<h1>Id = {id} </h1>");
        }

        // using route attribute pass in dynamic url template
        // pass in regex that limits year to 4 digit sring and one that limits month to 2 digit string between 1 and 12
        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"{year}/{month}");
        }

        
    }
}