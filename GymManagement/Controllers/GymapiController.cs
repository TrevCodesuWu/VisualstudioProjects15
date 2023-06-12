using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GymManagement.Controllers
{
    public class GymapiController : ApiController
    {
        // GET: api/Gymapi
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Gymapi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Gymapi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Gymapi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Gymapi/5
        public void Delete(int id)
        {
        }
    }
}
