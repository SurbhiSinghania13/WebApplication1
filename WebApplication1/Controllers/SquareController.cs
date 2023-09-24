using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class SquareController : ApiController
    {
        //Get api/Square/{id}
        public int Get(int id)
        {
            var product = id * id;
            return product;
        }
    }
}
