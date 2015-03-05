using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using myanmarticketService.DataObjects.BusTicket;
using myanmarticketService.Models;

namespace myanmarticketService.Controllers.BusTicket
{
    public class BusRoutesController : ApiController
    {
        private myanmarticketContext db = new myanmarticketContext();

        // GET: api/BusRoutes
        public IQueryable<BusRoute> GetBusRoutes()
        {
            return db.BusRoutes;
        }

        // GET: api/BusRoutes/5
        [ResponseType(typeof(BusRoute))]
        public IHttpActionResult GetBusRoute(string id)
        {
            BusRoute busRoute = db.BusRoutes.Find(id);
            if (busRoute == null)
            {
                return NotFound();
            }

            return Ok(busRoute);
        }

        // PUT: api/BusRoutes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBusRoute(string id, BusRoute busRoute)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != busRoute.Id)
            {
                return BadRequest();
            }

            db.Entry(busRoute).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BusRouteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/BusRoutes
        [ResponseType(typeof(BusRoute))]
        public IHttpActionResult PostBusRoute(BusRoute busRoute)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BusRoutes.Add(busRoute);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (BusRouteExists(busRoute.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = busRoute.Id }, busRoute);
        }

        // DELETE: api/BusRoutes/5
        [ResponseType(typeof(BusRoute))]
        public IHttpActionResult DeleteBusRoute(string id)
        {
            BusRoute busRoute = db.BusRoutes.Find(id);
            if (busRoute == null)
            {
                return NotFound();
            }

            db.BusRoutes.Remove(busRoute);
            db.SaveChanges();

            return Ok(busRoute);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BusRouteExists(string id)
        {
            return db.BusRoutes.Count(e => e.Id == id) > 0;
        }
    }
}