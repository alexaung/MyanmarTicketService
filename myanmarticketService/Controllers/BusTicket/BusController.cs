using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.WindowsAzure.Mobile.Service;
using myanmarticketService.DataObjects.BusTicket;
using myanmarticketService.Models;
using System.Web.Http.Description;
using System.Web;

namespace myanmarticketService.Controllers.BusTicket
{
    public class BusController : ApiController
    {
        private myanmarticketContext db = new myanmarticketContext();

        // GET: api/Bus/{searchCriteria}
        public IQueryable<BusResult> GetBusResults(string fromCity, string toCity, string departDate, string returnDate)
        {
            //var dDate = Convert.ToDateTime(departDate);
            //var rDate = Convert.ToDateTime(returnDate);
            DateTime dDate = DateTime.ParseExact(departDate, "dd-MMM-yyyy",
                                       System.Globalization.CultureInfo.InvariantCulture);
            DateTime rDate = DateTime.ParseExact(returnDate, "dd-MMM-yyyy",
                                       System.Globalization.CultureInfo.InvariantCulture);
            var query = from busSchedule in db.BusSchedules
                        join busRoute in db.BusRoutes on busSchedule.BusRoute_Id equals busRoute.Id
                        select new BusResult
                        {
                            BusRoutId = busRoute.Id,
                            BusName = busRoute.Name
                        };

            return query;
        }
    }
}
