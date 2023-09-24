using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class NumberMachineController : ApiController
    {
        //Get api/NumberMachine/{id}
        public IHttpActionResult Get(int id)
        {
            var result = new
            {
                multiplication = id * 2,
                addition = id + 5,
                subtraction = id - 3,
                division = id / 2

            };
            return Ok(result);
        }
    }
}
