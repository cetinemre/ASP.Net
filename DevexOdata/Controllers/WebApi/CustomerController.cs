using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using DevexOdata.Models;

namespace DevexOdata.Controllers
{
    public class CustomerController : ApiController
    {
        // GET: Customer
        public IHttpActionResult GetAll()
        {
            ApplicationDbContext db= new ApplicationDbContext();
            return Ok(new
                {
                    success =true,
                    data=db.Customers.ToList()
                });
        }
    }
}