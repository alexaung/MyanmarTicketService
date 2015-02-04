using System;
using Microsoft.WindowsAzure.Mobile.Service;

namespace myanmarticketService.DataObjects
{
    public class Transfer : EntityData
    {
        public string Service { get; set; }
        public string PickUp { get; set; }
        public string FlightNo { get; set; }
        public string From  { get; set; }
        public string To { get; set; }

        public virtual Car Car { get; set; }
        public virtual Booking Booking { get; set; }
    }
}