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
    public class Movies_apiController : ApiController
    {
        private ApplicationDbContext context; 
        public Movies_apiController()
        {
            context = new ApplicationDbContext(); 
        }

        // GET: api/Movies_api
        public IEnumerable<MovieDTO> Get()
        {
            return context.Movies.ToList().Select(Mapper.Map<Movie, MovieDTO>); 
        }

        // GET: api/Movies_api/5
        public IHttpActionResult Get(int id)
        {
            var moviefromdb = context.Movies.SingleOrDefault(c => c.movie_id == id); 
            if(moviefromdb == null)
            {
                return NotFound(); 
            }

            return Ok(Mapper.Map<Movie, MovieDTO>(moviefromdb)); 
        }

        // POST: api/Movies_api
        [HttpPost]
        public IHttpActionResult Post(MovieDTO moviedto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(); 
            }
            var movieindb = Mapper.Map<MovieDTO, Movie>(moviedto);
            context.Movies.Add(movieindb);
            context.SaveChanges();
            movieindb.movie_id = moviedto.movie_id;

            return Created(new Uri(Request.RequestUri + "/" + movieindb.movie_id), moviedto); 
        }

        // PUT: api/Movies_api/5
        [HttpPut]
        public void Put(int id ,MovieDTO moviedto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest); 
            }
            var moviefromdb = context.Movies.SingleOrDefault(c => c.movie_id == id); 
            if(moviefromdb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound); 
            }
            Mapper.Map(moviedto, moviefromdb);
            context.SaveChanges(); 
        }

        // DELETE: api/Movies_api/5
        [HttpDelete]
        public void Delete(int id)
        {
            var moviefromdb = context.Movies.SingleOrDefault(c => c.movie_id == id); 
            if(moviefromdb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound); 
            }
            context.Movies.Remove(moviefromdb); 
            context.SaveChanges(); 
        }
    }
}
