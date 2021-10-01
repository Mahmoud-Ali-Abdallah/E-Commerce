using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace eCommerce.Web.Controllers
{
    public class AuthenticationController : Controller
    {

        [Route("/authenticate")]
        public async Task<IActionResult> Authenticate([FromQuery] string userName, [FromQuery] string pwd)
        {
            if (userName == "admin" && pwd == "adminadmin")
            {
                var usersClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name , userName),
                    new Claim(ClaimTypes.Email, "admin@eCommerce.com"),
                    new Claim(ClaimTypes.HomePhone , "123456789"),
                    new Claim(ClaimTypes.Role , "Admin")

                };

                var userIdentity = new ClaimsIdentity(usersClaims, "eCommerce.CookieAuth");

                var userPrincipal = new ClaimsPrincipal(userIdentity);

                await HttpContext.SignInAsync("eCommerce.CookieAuth", userPrincipal);
            }

            if (userName == "user" && pwd == "useruser")
            {
                var usersClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name , userName),
                    new Claim(ClaimTypes.Email, "admin@eCommerce.com"),
                    new Claim(ClaimTypes.HomePhone , "123456789")
                };

                var userIdentity = new ClaimsIdentity(usersClaims, "eCommerce.CookieAuth");

                var userPrincipal = new ClaimsPrincipal(userIdentity);

                await HttpContext.SignInAsync("eCommerce.CookieAuth", userPrincipal);
            }

            return Redirect( "/outstandingorders");
        }

        [Route("/logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/outstandingorders");
        }
    }
}
