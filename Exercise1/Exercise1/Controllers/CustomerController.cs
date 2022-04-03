using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercise1.Models;

namespace Exercise1.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customer = new List<Customer> {
                new Customer{Id=1,Name="Customer 1"},
                new Customer{Id=2,Name="Customer 2"}
            };
        
            return View(customer);
        }
    }
}