using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.WindowsAzure.Mobile.Service;
using myanmarticketService.DataObjects;
using myanmarticketService.Models;

namespace myanmarticketService.Controllers
{
    public class AirPortController : TableController<AirPort>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            myanmarticketContext context = new myanmarticketContext();
            DomainManager = new EntityDomainManager<AirPort>(context, Request, Services);
        }

        // GET tables/AirPort
        public IQueryable<AirPort> GetAllAirPort()
        {
            return Query(); 
        }

        // GET tables/AirPort/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<AirPort> GetAirPort(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/AirPort/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<AirPort> PatchAirPort(string id, Delta<AirPort> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/AirPort
        public async Task<IHttpActionResult> PostAirPort(AirPort item)
        {
            AirPort current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/AirPort/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteAirPort(string id)
        {
             return DeleteAsync(id);
        }

    }
}