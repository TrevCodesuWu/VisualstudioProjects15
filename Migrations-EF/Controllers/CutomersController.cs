using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Migrations_EF.Models;
using AutoMapper;
using Migrations_EF.DTOs;

namespace Migrations_EF.Controllers
{
    public class CutomersController : ApiController
    {
        private ApplicationDbContext context; 
        public CutomersController()
        {
            context = new ApplicationDbContext(); 
        }
        // GET: api/Cutomers
        public IEnumerable<CustomerDTO> GetCustomers()
        {
            var c = context.Customers.ToList().Select(Mapper.Map<Customer, CustomerDTO>);

            return c;
        }

        // GET: api/Cutomers/5
        public IHttpActionResult GetCustomer(int id)
        {
            var singleCust = context.Customers.SingleOrDefault(c => c.id == id); 
            if(singleCust == null)
            {
                return NotFound(); 
            }
            return Ok(Mapper.Map<Customer,CustomerDTO>(singleCust));
        }

        // POST: api/Cutomers
        [HttpPost]
        public IHttpActionResult PostCustomer(CustomerDTO customerdto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();  
            }
            var cust = Mapper.Map<CustomerDTO, Customer>(customerdto);
            context.Customers.Add(cust);
            context.SaveChanges();

            cust.id = customerdto.id;

            return Created(new Uri(Request.RequestUri + "/" + cust.id), customerdto);
        }

        // PUT: api/Cutomers/5
        [HttpPut]
        public void Put( int id , CustomerDTO customer)
        {
            var cust = context.Customers.SingleOrDefault(c => c.id == id);
            if(cust == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound); 
            }
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest); 
            }
            Mapper.Map(customer, cust);
            context.SaveChanges(); 

        }

        // DELETE: api/Cutomers/5
        [HttpDelete]
        public void Delete(int id)
        {
            var singleCust = context.Customers.SingleOrDefault(c => c.id == id);
            if (singleCust == null)
            {
                NotFound(); 
            }
            context.Customers.Remove(singleCust);
            context.SaveChanges(); 
        }
    }
}
