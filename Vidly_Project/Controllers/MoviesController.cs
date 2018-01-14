using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Vidly_Project.Models;
using Vidly_Project.ViewModels;

namespace Vidly_Project.Controllers
{
    public class MoviesController : Controller
    {

        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movies/Random
        //public ActionResult Random()
        //{
        //    var movie = new Movie() {Name = "Shrek"};

        //   // RandomMovieViewModel vm = new RandomMovieViewModel{Movie = movie, Customers = customers};

        //    return View(vm);

        //}

        public ActionResult Edit(int id)
        {
            return Content("Id is" + id);
        }

        //movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue) pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy)) sortBy = "Name";
            var movies = _context.Movies.Include(g => g.Genre).ToList();
            return View(movies);
        }

        [Route("movies/details/{id}")]
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(g => g.Genre).FirstOrDefault(c => c.Id == id);
            if (movie != null)
            {
                //MovieDetailsViewModel vm = new MovieDetailsViewModel { Movie = movie };
                return View(movie);
            }
            else
            {
                return HttpNotFound();
            }
        }


        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{1,2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            
            return Content(year + "/" + month);
        }


    }
}