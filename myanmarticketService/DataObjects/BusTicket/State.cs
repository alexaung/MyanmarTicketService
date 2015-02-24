using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Mobile.Service;

namespace myanmarticketService.DataObjects.BusTicket
{
    public class State : EntityData
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
