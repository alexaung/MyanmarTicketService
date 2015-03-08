using System;
using Microsoft.WindowsAzure.Mobile.Service;

namespace myanmarticketService.DataObjects
{
    public class Car : CustomEntityData
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int SeatingCapacity { get; set; }
        public int Luggage { get; set; }
        public decimal Rates { get; set; }
        public string Image { get; set; }
        public string AirportCode { get; set; }
        public virtual AirPort Airport { get; set; }
    }
}