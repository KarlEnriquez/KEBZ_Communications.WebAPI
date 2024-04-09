using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Microsoft.AspNetCore.JsonPatch;
using Shared.DataTransferObjects;

namespace KEBZ_Communications.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // Attribute routing, Auto 400 response, binding source parameter, multi-part/form-data inference, problem details for status codes
    public class UserController : ControllerBase
    {
        private readonly IServiceManager _service;

        public UserController(IServiceManager serviceManager) => _service = serviceManager;


        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _service.User.GetAllUsers(trackChanges: false);
            return Ok(users);
        }

        [HttpGet("{id:guid}", Name = "UserById")]
        public IActionResult GetUser(Guid id)
        {
            var User = _service.User.GetUser(id, trackChanges: false);
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
            return CreatedAtRoute("UserById", new { id = createdUser.UserId }, createdUser);
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteUser(Guid id)
        {
            _service.User.DeleteUser(id, trackChanges: false);
            return NoContent();
        }

        // [HttpPut("{id:guid}")]
        // public  IActionResult UpdateUser(Guid id, [FromBody] UserForUpdateDto User)
        // {
        //     if (User == null)
        //         return BadRequest("UserForUpdateDto object is null");

        //     if (!ModelState.IsValid)
        //         return UnprocessableEntity(ModelState);

        //      _service.User.UpdateUser(id, User, trackChanges: true);
        //     return NoContent();
        // }

        // /// <summary>
        // /// Patch Operations
        // /// Add, Replace, Remove
        // /// Copy, Move, Test
        // /// Properties within a Patch Request:
        // /// op: operation, path: path to the property, value: value to be used
        // [HttpPatch("{id:guid}")]
        // public  IActionResult PartiallyUpdateUser(Guid id, [FromBody] JsonPatchDocument<UserForUpdateDto> patchDocument)
        // {
        //     if (patchDocument is null)
        //         return BadRequest("patchDocument object sent from client is null");

        //     var result =  _service.User.GetUserForPatch(id, trackChanges: true);
        //     patchDocument.ApplyTo(result.UserForUpdate);

        //     TryValidateModel(result.UserForUpdate);

        //     if (!ModelState.IsValid)
        //         return UnprocessableEntity(ModelState);

        //      _service.User.SaveChangesForPatch(result.UserForUpdate, result.UserEntity);

        //     return NoContent();
        // }

    }
}
