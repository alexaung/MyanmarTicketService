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
using myanmarticketService.DataObjects;
using myanmarticketService.Models;
using myanmarticketService.Utilities;
using PayPal.Api;
using Microsoft.WindowsAzure.Mobile.Service;

namespace myanmarticketService.Controllers
{
    public class PayPalController : ApiController
    {
        private Models.myanmarticketContext db = new Models.myanmarticketContext();

        // POST: api/PayPal
        [ResponseType(typeof(Booking))]
        public IHttpActionResult VerifyMobilePayment(Booking booking)
        {

            var apiContext = myanmarticketService.Utilities.Configuration.GetAPIContext();

            var payment = Payment.Get(apiContext, booking.PaymentId);

            booking.PaymentState = payment.state;
            
            Booking entity = db.Bookings.Find(booking.Id);
            db.Entry(entity).State = EntityState.Modified;
            entity.PaymentState = payment.state;
            db.SaveChanges();

            return Ok(entity);
            
        }

        // GET: api/Bookings/5
        [ResponseType(typeof(Booking))]
        public IHttpActionResult GetBooking(string id)
        {

            Booking booking = db.Bookings.Find(id);
            if (booking == null)
            {
                return NotFound();
            }

            return Ok(booking);

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
