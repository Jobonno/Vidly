using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_Project.Models;

namespace Vidly_Project.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
    }
}