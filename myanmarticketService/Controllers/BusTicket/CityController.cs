using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.WindowsAzure.Mobile.Service;
using myanmarticketService.DataObjects.BusTicket;
using myanmarticketService.Models;

namespace myanmarticketService.Controllers.BusTicket
{
    public class CityController : TableController<City>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            myanmarticketContext context = new myanmarticketContext();
            DomainManager = new EntityDomainManager<City>(context, Request, Services);
        }

        // GET tables/City
        public IQueryable<City> GetAllCity()
        {
            return Query(); 
        }

        // GET tables/City/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<City> GetCity(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/City/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<City> PatchCity(string id, Delta<City> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/City
        public async Task<IHttpActionResult> PostCity(City item)
        {
            City current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/City/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteCity(string id)
        {
             return DeleteAsync(id);
        }

    }
}