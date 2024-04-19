using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Microsoft.AspNetCore.JsonPatch;
using Shared.DataTransferObjects;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace KEBZ_Communications.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // Attribute routing, Auto 400 response, binding source parameter, multi-part/form-data inference, problem details for status codes
    [Authorize]

   
    public class UserController : ControllerBase
    {
        private readonly IServiceManager _service;

        public UserController(IServiceManager serviceManager) => _service = serviceManager;

         protected Guid GetUserId()
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


        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _service.User.GetAllUsers(trackChanges: false);
            return Ok(users);
        }

        [HttpGet]
        public IActionResult GetCurrentUser()
        {
            var User = _service.User.GetUser(GetUserId(), trackChanges: false);
            return Ok(User);

        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] UserForCreationDto User)
        {
            if (User == null)
                return BadRequest("UserForCreationDto object is null");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            var createdUser = _service.User.CreateUser(User);
            return CreatedAtRoute("UserById", new { id = createdUser.Id }, createdUser);
        }

        [HttpDelete]
        public IActionResult DeleteUser()
        {
            _service.User.DeleteUser(GetUserId(), trackChanges: false);
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateUser( [FromBody] UserForUpdateDto User)
        {
            if (User == null)
                return BadRequest("UserForUpdateDto object is null");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            _service.User.UpdateUser(GetUserId(), User, trackChanges: true);
            return NoContent();
        }

        // /// <summary>
        // /// Patch Operations
        // /// Add, Replace, Remove
        // /// Copy, Move, Test
        // /// Properties within a Patch Request:
        // /// op: operation, path: path to the property, value: value to be used
        [HttpPatch]
        public IActionResult PartiallyUpdateUser( [FromBody] JsonPatchDocument<UserForUpdateDto> patchDocument)
        {
            if (patchDocument is null)
                return BadRequest("patchDocument object sent from client is null");

            var result = _service.User.GetUserForPatch(GetUserId(), trackChanges: true);
            patchDocument.ApplyTo(result.UserForUpdate);

            TryValidateModel(result.UserForUpdate);

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            _service.User.SaveChangesForPatch(result.UserForUpdate, result.UserEntity);

            return NoContent();
        }

    }
}
