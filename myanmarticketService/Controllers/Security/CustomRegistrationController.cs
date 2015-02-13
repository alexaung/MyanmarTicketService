using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web.Http;
using Microsoft.WindowsAzure.Mobile.Service;
using Microsoft.WindowsAzure.Mobile.Service.Security;
using myanmarticketService.DataObjects;
using myanmarticketService.DataObjects.Security;
using myanmarticketService.Models;
using myanmarticketService.Security;
using myanmarticketService.Utilities;

namespace myanmarticketService.Controllers.Security
{
    [AuthorizeLevel(AuthorizationLevel.Anonymous)]
    public class CustomRegistrationController : ApiController
    {
        public ApiServices Services { get; set; }

        // POST api/CustomRegistration
        public HttpResponseMessage Post(RegistrationRequest registrationRequest)
        {
            if (!RegexUtilities.IsValidUserName(registrationRequest.username))
            {
                return this.Request.CreateResponse(HttpStatusCode.BadRequest, "Invalid username (at least 4 chars, alphanumeric only)");
            }
            else if (!RegexUtilities.IsValidEmail(registrationRequest.email)) 
            {
                return this.Request.CreateResponse(HttpStatusCode.BadRequest, "Invalid email");
            }
            else if (registrationRequest.password.Length < 8)
            {
                return this.Request.CreateResponse(HttpStatusCode.BadRequest, "Invalid password (at least 8 chars required)");
            }

            myanmarticketContext context = new myanmarticketContext();
            Account account = context.Accounts.Where(a => a.Email == registrationRequest.email).SingleOrDefault();
            if (account != null)
            {
                return this.Request.CreateResponse(HttpStatusCode.BadRequest, "Email already exists");
            }
            else
            {
                byte[] salt = CustomLoginProviderUtils.generateSalt();
                Account newAccount = new Account
                {
                    Id = Guid.NewGuid().ToString(),
                    Email = registrationRequest.email,
                    Username = registrationRequest.username,
                    Phone = registrationRequest.phone,
                    Salt = salt,
                    SaltedAndHashedPassword = CustomLoginProviderUtils.hash(registrationRequest.password, salt)
                };
                context.Accounts.Add(newAccount);
                context.SaveChanges();
                return this.Request.CreateResponse(HttpStatusCode.Created);
            }
        }
    }   
}
