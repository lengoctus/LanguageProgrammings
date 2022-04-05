using DemoSession25_Security_EF.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DemoSession25_Security_EF.Security
{

    public class SecurityManage
    {
        public void SignIn(HttpContext httpContext, Account account)
        {
            // Lay inf cua acc luu vao cookie
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(getUserClaims(account), CookieAuthenticationDefaults.AuthenticationScheme);

            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

            httpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);
        }

        public void SignOut(HttpContext httpContext)
        {
            httpContext.SignOutAsync();
        }

        private IEnumerable<Claim> getUserClaims(RoleDetails roleD)
        {
            // Luu thong tin cua acc vao list.
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim("AccountId", "" + roleD.AccountId));
            foreach (var role in account.Role)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            return claims;
        }
    }


}
