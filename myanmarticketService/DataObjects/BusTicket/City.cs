using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Mobile.Service;

namespace myanmarticketService.DataObjects.BusTicket
{
    public class City : CustomEntityData
    {
        public string Name { get; set; }
        public string State_Id { get; set; }
        [ForeignKey("State_Id")]
        public virtual State State { get; set; }
    }
}
