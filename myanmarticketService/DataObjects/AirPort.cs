using System;
using System.Collections.Generic;
using Microsoft.WindowsAzure.Mobile.Service;

namespace myanmarticketService.DataObjects
{
    public class AirPort : CustomEntityData
    {
        public string Name { get; set; }

        public bool Active { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}