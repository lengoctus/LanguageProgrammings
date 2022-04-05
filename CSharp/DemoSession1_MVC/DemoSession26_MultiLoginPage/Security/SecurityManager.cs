using Microsoft.AspNetCore.Http;
using DemoSession26_MultiLoginPage.Models;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace DemoSession26_MultiLoginPage.Security
{
    public class SecurityManager
    {
        public async void SignIn(HttpContext httpContext, Account account, string Schema)
        {
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(getUserClaims(account), Schema);
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            await httpContext.SignInAsync(Schema, claimsPrincipal);
        }

        public async void SignOut(HttpContext httpContext, string Schema)
        {
            await httpContext.SignOutAsync(Schema);
        }

        private IEnumerable<Claim> getUserClaims(Account account)
        {
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, account.Username));
            foreach (var roleAccount in account.RoleAccount)
            {
                claims.Add(new Claim(ClaimTypes.Role, roleAccount.Role.Name));
            }
            return claims;
        }
    }
}
