using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MASGlobalApp.Repository;
using MASGlobalApp.Business.Classes;


namespace MASGlobalApp.Controllers
{
    public class EmployeesController : ApiController
    {
        
        
        // GET api/values
        public IEnumerable<EmployeeDto> Get()
        {
            return HttpClientRepo.GetEmployees();
        }

        // GET api/values/5
        public IEnumerable<EmployeeDto> Get(int id)
        {
            return HttpClientRepo.GetEmployees().Where( e => e.id == id.ToString());
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
