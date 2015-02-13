using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.WindowsAzure.Mobile.Service;
using myanmarticketService.DataObjects;
using myanmarticketService.Models;
using myanmarticketService.Utilities;

namespace myanmarticketService.Controllers
{
    public class BookingController : TableController<Booking>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            myanmarticketContext context = new myanmarticketContext();
            DomainManager = new EntityDomainManager<Booking>(context, Request, Services);
        }

        // GET tables/Booking
        public IQueryable<Booking> GetAllBooking()
        {
            return Query(); 
        }

        // GET tables/Booking/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Booking> GetBooking(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Booking/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Booking> PatchBooking(string id, Delta<Booking> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Booking
        public async Task<IHttpActionResult> PostBooking(Booking item)
        {
            item.Code = KeyGenerator.GetUniqueKey();
            Booking current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Booking/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteBooking(string id)
        {
             return DeleteAsync(id);
        }

    }
}