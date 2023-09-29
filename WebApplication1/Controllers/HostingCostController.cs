using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{

    public class HostingCostController : ApiController
    {
        /// <summary>
        /// This code prints 3 strings which describes the total hosting cost.
        /// </summary>
        /// <param name="id">0</param>
        /// <returns>{"CostBeforeTax":"$5.50","HST":"$0.72","TotalCost":"$6.22"}</returns>

        //Get api/HostingCost/{id}
        public IHttpActionResult Get(int id)
        {
            double value = (double)id / 14;
            double fortnights = value + 1;
            double costBeforeTax = fortnights * 5.50;
            double hst = costBeforeTax * 0.13;
            double totalCost = costBeforeTax + hst;

            string costDescription = $"${costBeforeTax:F2}";
            string hstDescription = $"${hst:F2}";
            string totalDescription = $"${totalCost:F2}";

            return Ok(new { CostBeforeTax = costDescription, HST = hstDescription, TotalCost = totalDescription });
        }
    }
}
