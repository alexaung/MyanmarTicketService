using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public double Rate { get; set; }
        public bool IsSameAsAccount { get; set; }
        public string Account_Id { get; set; }

        [ForeignKey("Account_Id")]
        public virtual Account BookBy { get; set; }
        public virtual ICollection<Transfer> Transfers { get; set; }
        public virtual Personal Personal { get; set; }
    }
}