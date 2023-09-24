using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class Greeting2Controller : ApiController
    {
        //Get api/Greeting2/{id}
        public string Get(string id)
        {
            var product = "Greeting to " + id + " people";
            return product;
        }
    }
}
