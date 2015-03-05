using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.WindowsAzure.Mobile.Service;
using myanmarticketService.DataObjects.BusTicket;
using myanmarticketService.Models;

namespace myanmarticketService.Controllers.BusTicket
{
    public class BusController : ApiController
    {
        private myanmarticketContext db = new myanmarticketContext();

        // GET: api/Bus
        public IQueryable<BusResult> GetBusResults(SearchCriteria searchCriteria)
        {
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
