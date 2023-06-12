using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web_REST_API.Models; 

namespace Web_REST_API.Controllers
{
    public class PeopleController : ApiController
    {
        List<People> persons = new List<People>()
        {
            new People {id=1 , first_name="Trevlin",last_name="Naicker" },
            new People {id=2 , first_name="Kylan" ,last_name="Govender" },
            new People {id=3 ,first_name="Ghost",last_name="Pops" }
        };

        
        // GET: api/People
        public List<People> Get()
        {
            return persons; 
        }

        // GET: api/People/5
        public People Get(int id)
        {
            var singlePerson = persons.SingleOrDefault(c => c.id == id);

            return singlePerson; 
        }

        // POST: api/People
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/People/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
