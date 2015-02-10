using System;
using System.Collections.Generic;
using Microsoft.WindowsAzure.Mobile.Service;

namespace myanmarticketService.DataObjects
{
    public class Booking : EntityData
    {
        public string Code { get; set; }
        public string BookingDate { get; set; }
        public string PaymentMode { get; set; }
        public string PaymentId { get; set; }
        public string PaymentState { get; set; }

        public virtual User BookBy { get; set; }
        public virtual ICollection<Transfer> Transfers { get; set; }
        public virtual PersonalInfo PersonalInfo { get; set; }
    }
}