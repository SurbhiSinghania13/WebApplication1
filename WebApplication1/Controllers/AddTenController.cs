using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// This code operates addition of 10 of the input value.
        /// </summary>
        /// <param name="id">10</param>
        /// <returns>20</returns>
       
        //Get api/AddTen/{id}
        public int Get(int id)
        {
            var product = id + 10;
            return product;
        }
    }
}
