using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Mobile.Service;

namespace myanmarticketService.DataObjects.BusTicket
{
    public class BusSchedule : EntityData
    {
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public string BusRoute_Id { get; set; }
        [ForeignKey("BusRoute_Id")]
        public virtual BusRoute BusRoute { get; set; }
    }
}
