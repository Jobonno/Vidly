using System;
using System.Collections.Generic;
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

        private List<Movie> movies = new List<Movie>
        {
            new Movie() {Id= 1,Name = "Shrek"},
            new Movie() {Id= 2,Name = "Wall-e"},

    };

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
            MoviesIndexViewModel vm = new MoviesIndexViewModel {Movies = movies};
            return View(vm);
        }

        [Route("movies/details/{id}")]
        public ActionResult Details(int id)
        {
            Movie movie = movies.FirstOrDefault(c => c.Id == id);
            if (movie != null)
            {
                MovieDetailsViewModel vm = new MovieDetailsViewModel { Movie = movie };
                return View(vm);
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