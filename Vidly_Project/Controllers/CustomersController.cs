using System;
using System.Collections.Generic;
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
        private List<Customer> customers = new List<Customer>
        {
            new Customer {Id = 1 , Name = "John Smith"},
            new Customer {Id = 2 , Name = "Mary Williams"}
        };


        // GET: Customers
        public ActionResult Index()
        {
            
            CustomerIndexViewModel vm = new CustomerIndexViewModel
            {
                Customers = customers
            };
            return View(vm);
        }

        [Route("customers/details/{id}")]
        public ActionResult Details(int id)
        {
            Customer customer =  customers.FirstOrDefault(c => c.Id == id);
            if (customer != null)
            {
                CustomerDetailsViewModel vm = new CustomerDetailsViewModel {Customer = customer};
                return View(vm);
            }
            else
            {
                return HttpNotFound();
            }
        }
    }
}