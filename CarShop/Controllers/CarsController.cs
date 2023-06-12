using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CarShop.Models;
using CarShop.DTOs;
using AutoMapper;
using System.Data.Entity; 

namespace CarShop.Controllers
{
    public class CarsController : ApiController
    {
        private ApplicationDbContext context;
        public CarsController()
        {
            context = new ApplicationDbContext(); 
        }

        // GET: api/Cars
        public /*IEnumerable<CarDTO>*/ IHttpActionResult Get()
        {
            var listcars = context.dbCar.Include(c => c.Class).ToList().Select(Mapper.Map<Car, CarDTO>);

            return Ok(listcars); 
        }

        // GET: api/Cars/5
        public IHttpActionResult Get(int id)
        {
            var fromDb = context.dbCar.SingleOrDefault(c => c.id == id);
            if(fromDb == null)
            {
                return NotFound(); 
            }
            return Ok(Mapper.Map<Car,CarDTO>(fromDb)); 
        }

        // POST: api/Cars
        [HttpPost]
        public IHttpActionResult Post(CarDTO cardto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(); 
            }
            var fromdb = Mapper.Map<CarDTO, Car>(cardto);

            context.dbCar.Add(fromdb);
            context.SaveChanges();

            cardto.id = fromdb.id;

            return Created(new Uri(Request.RequestUri + "/" + fromdb.id), cardto); 
        }

        // PUT: api/Cars/5
        [HttpPut]
        public IHttpActionResult Put(int id, CarDTO cardto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(); 
            }
            var value = context.dbCar.Single(cc => cc.id == id);
            if(value == null)
            {
                return NotFound(); 
            }
            Mapper.Map(cardto, value);

            context.SaveChanges();

            return Ok(); 
        }

        // DELETE: api/Cars/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var value = context.dbCar.SingleOrDefault(c => c.id == id);
            if (value == null)
            {
                return NotFound(); 
            }
            context.dbCar.Remove(value);
            context.SaveChanges();

            return Ok();
        }
    }
}
