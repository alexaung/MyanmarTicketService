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


namespace myanmarticketService.Controllers
{
    public class PaypalController : ApiController
    {
        private myanmarticketContext db = new myanmarticketContext();
        // POST: api/VerifyMobilePayment
        [ResponseType(typeof(Booking))]
        public IHttpActionResult VerifyMobilePayment(Booking booking)
        {
            try
            {
                var apiContext = myanmarticketService.Utilities.Configuration.GetAPIContext();

                var payment = Payment.Get(apiContext, booking.PaymentId);

                booking.PaymentState = payment.state;

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                db.Entry(booking).State = EntityState.Modified;


                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }

            return CreatedAtRoute("DefaultApi", new { id = booking.Id }, booking);
        }
    }
}
