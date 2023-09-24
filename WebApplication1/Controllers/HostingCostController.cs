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
        //Get api/HostingCost/{id}
        public IHttpActionResult Get(int id)
        {
            double value = (double)id / 14;
            double fortnights = value + 1;
            double costBeforeTax = fortnights * 5.50;
            double hst = costBeforeTax * 0.13;
            double totalCost = costBeforeTax + hst;

            string costDescription = $"${costBeforeTax:F2} (Cost before tax)";
            string hstDescription = $"${hst:F2} (13% HST)";
            string totalDescription = $"${totalCost:F2} (Total cost including tax)";

            return Ok(new { CostBeforeTax = costDescription, HST = hstDescription, TotalCost = totalDescription });
        }
    }
}
