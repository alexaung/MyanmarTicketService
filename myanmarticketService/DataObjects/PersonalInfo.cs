using System;
using Microsoft.WindowsAzure.Mobile.Service;

namespace myanmarticketService.DataObjects
{
    public class PersonalInfo : EntityData
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NoofPassengers { get; set; }
        public string SpecialInstructions { get; set; }
        
        public virtual Booking Booking { get; set; }
    }
}