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
    }
}