using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JobApplicationForm.Models;
using JobApplicationForm.DTOs;
using System.Data.Entity; 
using AutoMapper; //need this namespace to use it

namespace JobApplicationForm.Controllers
{
    public class JobsController : ApiController
    {
        private ApplicationDbContext context; 
        public JobsController()
        {
            context = new ApplicationDbContext(); 
        }
        // GET  api/Jobs
       public IEnumerable<JobFormDTO> GetForms()
        {
            var listjobs = context.JobFormDb.Include(c => c.Position).ToList().Select(Mapper.Map<JobForm,JobFormDTO>); 

            return listjobs; 
        }
        // GET  api/Jobs/1
        public IHttpActionResult GetForm(int id)
        {
            var singleform = context.JobFormDb.SingleOrDefault(c => c.id == id); 
            if(singleform == null)
            {
                return NotFound(); 
            }
            return Ok(Mapper.Map<JobForm,JobFormDTO>(singleform)); 
        }
        // POST api/Jobs
        [HttpPost]
        public IHttpActionResult PostJobform(JobFormDTO jobformdto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();  
            }
            var jobform = Mapper.Map<JobFormDTO, JobForm>(jobformdto); 

            context.JobFormDb.Add(jobform);
            context.SaveChanges();

            jobformdto.id = jobform.id;

            return Created(new Uri(Request.RequestUri + "/" + jobform.id), jobformdto); //last added 
        }
        // PUT api/Jobs/1
        [HttpPut]
        public void UpdateForm(int id , JobFormDTO jobformdto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var value = context.JobFormDb.SingleOrDefault(c => c.id == id); 
            if(value == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound); 
            }

            Mapper.Map(jobformdto, value); 

            context.SaveChanges(); 
           
        }
       // DELETE api/Jobs/1
       [HttpDelete]
       public void DeleteJobform(int id)
        {
            var singleform = context.JobFormDb.SingleOrDefault(c => c.id == id);
            if (singleform == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            context.JobFormDb.Remove(singleform);
            context.SaveChanges(); 
        }
    }
}
