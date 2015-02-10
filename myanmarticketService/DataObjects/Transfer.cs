using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.WindowsAzure.Mobile.Service;

namespace myanmarticketService.DataObjects
{
    public class Transfer : EntityData
    {
        public string Service { get; set; }
        public string FlightNo { get; set; }
        public string From  { get; set; }
        public string To { get; set; }
        public string TransferDate { get; set; }
        public int NoOfPassenger { get; set; }
        public int NoOfLuggage { get; set; }
        public string Car_Id { get; set; }

        [ForeignKey("Car_Id")]
        public virtual Car Car { get; set; }
        public virtual Booking Booking { get; set; }
    }
}