using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Web.Mvc;
using Vidly_Project.Models;
using Vidly_Project.ViewModels;

namespace Vidly_Project.Controllers
{
    public class CustomersController : Controller
    {

        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            
            return View();
        }


        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            //CustomerIndexViewModel vm = new CustomerIndexViewModel
            //{
            //    Customers = customers
            //};
            return View(customers);
        }

        [Route("customers/details/{id}")]
        public ActionResult Details(int id)
        {
            Customer customer = _context.Customers.Include(c => c.MembershipType).FirstOrDefault(c => c.Id == id);
            if (customer != null)
            {
                //CustomerDetailsViewModel vm = new CustomerDetailsViewModel {Customer = customer};
                return View(customer);
            }
            else
            {
                return HttpNotFound();
            }
        }
    }
}