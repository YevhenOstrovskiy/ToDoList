using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace ToDoList.Data
{
    public class TokenAuthenticationStateProvider : AuthenticationStateProvider
    {
        //public override Task<AuthenticationState> GetAuthenticationStateAsync()
        //{
        //    var anonymousIdentity = new ClaimsIdentity();
        //    var anonymousPrincipal = new ClaimsPrincipal(anonymousIdentity);
        //    return new AuthenticationState();
        //}
        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            throw new NotImplementedException();
        }
    }
}
