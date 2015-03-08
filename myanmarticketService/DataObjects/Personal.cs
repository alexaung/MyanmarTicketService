using System;
using Microsoft.WindowsAzure.Mobile.Service;

namespace myanmarticketService.DataObjects
{
    public class Personal : CustomEntityData
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}