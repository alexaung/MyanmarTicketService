using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        public string BusType_Id { get; set; }
        [ForeignKey("BusType_Id")]
        public BusType BusType { get; set; }

        public string FromCity_Id { get; set; }
        [ForeignKey("FromCity_Id")]
        public City FromCity { get; set; }

        public string ToCity_Id { get; set; }
        [ForeignKey("ToCity_Id")]
        public City ToCity { get; set; }

        public string BoardingPoint_Id { get; set; }
        [ForeignKey("BoardingPoint_Id")]
        public BusStation BoardingPoint { get; set; }

        public string DroppingPoint_Id { get; set; }
        [ForeignKey("DroppingPoint_Id")]
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
