using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Mobile.Service;

namespace myanmarticketService.DataObjects.BusTicket
{
    public class BusRoute : EntityData
    {
        public ServiceProvider ServiceProvider { get; set; }
        public string Name { get; set; }
        public BusType BusType { get; set; }
        public City FromCity { get; set; }
        public City ToCity { get; set; }
        public BusStation BoardingPoint { get; set; }
        public BusStation DroppingPoint { get; set; }
        public int Seats { get; set; }
        public double Fare { get; set; }
        public int DayOfWeek { get; set; }
        public virtual ICollection<BusSchedule> BusSchedules { get; set; }
        public virtual ICollection<BusImage> BusImages { get; set; }

        public virtual ICollection<Amenity> BusAmenities { get; set; }

        public BusRoute()
        {
            BusAmenities = new HashSet<Amenity>();
        }
    }
}
