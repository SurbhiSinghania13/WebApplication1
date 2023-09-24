using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace WebApplication1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// This code operatates four arithmetic operations: multiplication, addition, subtraction,and division.
        /// </summary>
        /// <param name="id">10</param>
        /// <returns>{"multiplication":20,"addition":15,"subtraction":7,"division":5}</returns>
     
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
