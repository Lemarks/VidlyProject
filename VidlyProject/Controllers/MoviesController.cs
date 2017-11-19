using System.Collections.Generic;
using System.Web.Mvc;
using VidlyProject.Models;

namespace VidlyProject.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        //public ActionResult Random()
        //{
        //    var movie = new Movie { Name = "Shrek!" };

        //    var customers = new List<Customer>
        //    {
        //        new Customer{Name = "Customer 1"},
        //        new Customer{Name = "Customer 2"}
        //    };

        //    var viewModel = new RandomMovieViewModel
        //    {
        //        Movie = movie,
        //        Customers = customers
        //    };


        //    return View(viewModel);

        //    ViewData["Movie"] = movie;
        //    ViewBag.Movie = movie;
        //    return View(movie);
        //    return Content("Hello");
        //    return HttpNotFound();
        //    return new EmptyResult();
        //    return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        //}

        //public ActionResult Edit(int id)
        //{
        //    return Content("id = " + id);
        //}

        // movies
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("pageIndex = {0} &sortBy = {1}", pageIndex, sortBy));
        //}

        //[Route("movies/release/{year}/{month:regex(\\d{2}):range(1,12)}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}

        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);

        }

        private static IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id = 1, Name = "Shrek"},
                new Movie {Id = 2, Name = "Mortal Kombat"}
            };
        }
    }
}