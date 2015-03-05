using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myanmarticketService.DataObjects.BusTicket
{
    public class SearchCriteria
    {
        public string FromCity { get; set; }
        public string ToCity { get; set; }
        public string DepartDate { get; set; }
        public string ReturnDate { get; set; }
    }
}