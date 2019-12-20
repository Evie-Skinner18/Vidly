using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Random()
        {
            var shrek = new Movie() { Name = "Shrek" };
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

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"{year}/{month}");
        }

        
    }
}