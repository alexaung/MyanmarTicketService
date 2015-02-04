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
    public class CarController : TableController<Car>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            myanmarticketContext context = new myanmarticketContext();
            DomainManager = new EntityDomainManager<Car>(context, Request, Services);
        }

        // GET tables/Car
        public IQueryable<Car> GetAllCar()
        {
            return Query(); 
        }

        // GET tables/Car/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Car> GetCar(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Car/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Car> PatchCar(string id, Delta<Car> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Car
        public async Task<IHttpActionResult> PostCar(Car item)
        {
            Car current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Car/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteCar(string id)
        {
             return DeleteAsync(id);
        }

    }
}