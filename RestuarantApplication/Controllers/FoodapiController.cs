using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestuarantApplication.Models;
using RestuarantApplication.DTOs;
using RestuarantApplication.App_Start;
using AutoMapper; 

namespace RestuarantApplication.Controllers
{
    public class FoodapiController : ApiController
    {
        private ApplicationDbContext context; 
        public FoodapiController()
        {
            context = new ApplicationDbContext(); 
        }

        // GET: api/Foodapi
        [HttpGet]
        public IEnumerable<FoodDto> GetFood()
        {
            return context.FoodDbSet.ToList().Select(Mapper.Map<Food, FoodDto>);
        }

        // GET: api/Foodapi/5
        public IHttpActionResult Get(int id)
        {
            var itemfromdb = context.FoodDbSet.SingleOrDefault(c => c.id == id); 
            if(itemfromdb == null)
            {
                return NotFound(); 
            }
            return Ok(Mapper.Map<Food,FoodDto>(itemfromdb)); 
        }

        // POST: api/Foodapi
        [HttpPost]
        public IHttpActionResult Post(FoodDto fooddto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var item = Mapper.Map<FoodDto,Food>(fooddto);

            context.FoodDbSet.Add(item);
            context.SaveChanges();

            fooddto.id = item.id; 

            return Created(new Uri(Request.RequestUri + "/" + item.id), fooddto);
        }

        // PUT: api/Foodapi/5
        [HttpPut]
        public IHttpActionResult Update(int id , FoodDto fooddto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(); 
            }
            var itemfromdb = context.FoodDbSet.SingleOrDefault(c => c.id == id);
            if (itemfromdb == null)
            {
                return NotFound(); 
            }
            Mapper.Map(fooddto, itemfromdb);
            context.SaveChanges();

            return Ok(); 
        }

        // DELETE: api/Foodapi/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var itemfromdb = context.FoodDbSet.SingleOrDefault(c => c.id == id);
            if (itemfromdb == null)
            {
                return NotFound(); 
            }
            context.FoodDbSet.Remove(itemfromdb);
            context.SaveChanges(); 

            return Ok();
        }
    }
}
