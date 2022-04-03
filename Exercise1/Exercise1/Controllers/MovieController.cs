using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercise1.Models;

namespace Exercise1.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            var movie = GetMovieList();
            return View(movie);
                       
        }

        public ActionResult MovieSpecificView(int Id)
        {
            var customer = GetMovieList().SingleOrDefault(c => c.Id == Id);
            if (customer == null)
                return HttpNotFound();
            else
                return View(customer);
        }

        public List<Movie> GetMovieList()
        {
            return new List<Movie> {
                new Movie{Id=1,Name="Movie 1"},
                new Movie{Id=2,Name="Movie 2"}
            };
        }
    }
}
 