using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;
using System.Security.Claims;


namespace KEBZ_Communications.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IServiceManager _service;

        public AuthenticationController(IServiceManager serviceManager) => _service = serviceManager;


        public Guid GetUserId()
        {
            var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(userIdString))
            {
                throw new UnauthorizedAccessException("User ID is missing.");
            }

            if (!Guid.TryParse(userIdString, out Guid userId))
            {
                throw new ArgumentException("User ID is invalid.");
            }

            return userId;
        }

        [HttpPost]

        public async Task<IActionResult> RegisterUser([FromBody] UserForRegistrationDto userForRegistration)
        {
            var result = await _service.Authentication.RegisterUser(userForRegistration);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }
            return Created();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Authenticate([FromBody] UserForAuthenticationDto userForAuthentication)
        {
            if (!await _service.Authentication.ValidateUser(userForAuthentication))
            {
                return Unauthorized();
            }

            return Ok(new { Token = await _service.Authentication.CreateToken(), userId = _service.Authentication.UserIDForClient(userForAuthentication).Result });
        }
    }
}