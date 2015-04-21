using System.Collections.Generic;
using System.Web.Http;

namespace Presentation.Controllers
{
    public class DependenciaPoaController : ApiController
    {
        // GET api/dependenciapoa
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/dependenciapoa/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/dependenciapoa
        public void Post([FromBody]string value)
        {
        }

        // PUT api/dependenciapoa/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/dependenciapoa/5
        public void Delete(int id)
        {
        }
    }
}
