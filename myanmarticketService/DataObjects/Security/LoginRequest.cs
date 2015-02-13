using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myanmarticketService.DataObjects.Security
{
    public class LoginRequest
    {
        public String email { get; set; }
        public String password { get; set; }
    }
}
