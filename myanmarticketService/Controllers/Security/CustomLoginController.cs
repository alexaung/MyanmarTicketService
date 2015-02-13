using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.WindowsAzure.Mobile.Service;
using Microsoft.WindowsAzure.Mobile.Service.Security;
using myanmarticketService.Models;
using myanmarticketService.DataObjects.Security;
using myanmarticketService.DataObjects;
using myanmarticketService.Security;
using System.Security.Claims;

namespace myanmarticketService.Controllers.Security
{
    [AuthorizeLevel(AuthorizationLevel.Anonymous)]
    public class CustomLoginController : ApiController
    {
        public ApiServices Services { get; set; }
        public IServiceTokenHandler handler { get; set; }

        // POST api/CustomLogin
        public HttpResponseMessage Post(LoginRequest loginRequest)
        {
            myanmarticketContext context = new myanmarticketContext();
            Account account = context.Accounts.Where(a => a.Email == loginRequest.email).SingleOrDefault();
            if (account != null)
            {
                byte[] incoming = CustomLoginProviderUtils.hash(loginRequest.password, account.Salt);

                if (CustomLoginProviderUtils.slowEquals(incoming, account.SaltedAndHashedPassword))
                {
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity();
                    claimsIdentity.AddClaim(new Claim(ClaimTypes.NameIdentifier, loginRequest.email));
                    LoginResult loginResult = new CustomLoginProvider(handler).CreateLoginResult(claimsIdentity, Services.Settings.MasterKey);
                    return this.Request.CreateResponse(HttpStatusCode.OK, loginResult);
                }
            }
            return this.Request.CreateResponse(HttpStatusCode.Unauthorized, "Invalid email or password");
        }
    }
}
