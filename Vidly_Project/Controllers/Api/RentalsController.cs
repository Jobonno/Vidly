using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly_Project.Dtos;
using Vidly_Project.Models;

namespace Vidly_Project.Controllers.Api
{
    public class RentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        //POST /api/rental
        [HttpPost]
        public IHttpActionResult CreateRental(RentalDto rentalDto)
        {
            Customer customer = _context.Customers.FirstOrDefault(c => c.Id == rentalDto.CustomerId);
            if(customer == null)
            {
                return BadRequest("Customer Not Found");
            }
            
            foreach(int id in rentalDto.MovieIds)
            {
                Movie movie = _context.Movies.FirstOrDefault(m => m.Id == id && m.NumberAvailable > 0);
                if (movie != null)
                {
                    movie.NumberAvailable -= 1;
                    _context.Rentals.Add(new Rental
                    {
                        Customer = customer,
                        DateRented = DateTime.Now,
                        Movie = movie
                    });

                    _context.SaveChanges();
                }
                
            }
            return Ok();
            
        }

    }
}
