using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IAuthenticationService
    {
        Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistration);
        Task<bool> ValidateUser(UserForAuthenticationDto userForAuthentication);
        Task<string> CreateToken();
        Task<Guid?> UserIDForClient(UserForAuthenticationDto userForAuthentication);
    }
}
