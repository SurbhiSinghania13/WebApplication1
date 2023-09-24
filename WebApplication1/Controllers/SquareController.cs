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
        /// <summary>
        /// This code prints square of input value
        /// </summary>
        /// <param name="id">5</param>
        /// <returns>25</returns>
         
        //Get api/Square/{id}
        public int Get(int id)
        {
            var product = id * id;
            return product;
        }
    }
}
