using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using Vidly_Project.Models;

namespace Vidly_Project.ViewModels
{
    public class CustomerIndexViewModel
    {
        public List<Customer> Customers { get; set; }
    }
}