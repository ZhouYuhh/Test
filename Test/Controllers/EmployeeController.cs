using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Test.Controllers
{

        using Models;
 
    public class EmployeeController : ApiController
    {
        // GET api/Employee
        public IEnumerable<String> Get()
        {
            return new Bizlogic().ListEmployees();
        }

        // GET api/Employee/e1010
        public Employee Get(String id)
        {
            return new Bizlogic().GetEmployee(id);
        }

        [HttpGet]
        [Route("api/Employee/brief")]
        public IEnumerable<BriefEmp> Get2()
        {
            return new Bizlogic().ListEmployees2();
        }
    }

}
