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
        //Get api/AddTen/{id}
        public int Get(int id)
        {
            var product = id + 10;
            return product;
        }
    }
}
