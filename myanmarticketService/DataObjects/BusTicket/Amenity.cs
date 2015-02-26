using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Mobile.Service;

namespace myanmarticketService.DataObjects.BusTicket
{
    public class Amenity : EntityData
    {
        public string Name { get; set; }

        public virtual ICollection<BusRoute> BusRoutes { get; set; }

        public Amenity()
        {
            BusRoutes = new HashSet<BusRoute>();
        }
    }
}
