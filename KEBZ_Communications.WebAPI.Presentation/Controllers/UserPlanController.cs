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
    [Route("api/userplan")]
    [ApiController] // Attribute routing, Auto 400 response, binding source parameter, multi-part/form-data inference, problem details for status codes
    [Authorize]
    public class UserPlanController : ControllerBase
    {
        private readonly IServiceManager _service;

        public UserPlanController(IServiceManager serviceManager) => _service = serviceManager;

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

        [HttpGet]
        public IActionResult GetAllUserPlans()
        {
            var UserPlans = _service.UserPlan.GetAllUserPlans(GetUserId(), trackChanges: false);
            return Ok(UserPlans);
        }

        [HttpGet("{id:guid}", Name = "UserPlanById")]
        public IActionResult GetUserPlan(Guid id)
        {
            var UserPlan = _service.UserPlan.GetUserPlan(GetUserId(), id, trackChanges: false);
            return Ok(UserPlan);

        }

        [HttpPost]
        public IActionResult CreateUserPlan( [FromBody] UserPlanForCreationDto userPlan)
        {
            if (userPlan == null)
                return BadRequest("UserPlanForCreationDto object is null");

            userPlan.UserId = GetUserId(); // Ensuring the UserId is set correctly in the DTO

            var createdUserPlan = _service.UserPlan.CreateUserPlan(userPlan);
            return CreatedAtRoute("UserPlanById", new { UserId = GetUserId(), id = createdUserPlan.UserPlanId }, createdUserPlan);
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteUserPlan(Guid id)
        {
            _service.UserPlan.DeleteUserPlan(GetUserId(), id, trackChanges: false);
            return NoContent();
        }

        // [HttpPut("{id:guid}")]
        // public  IActionResult UpdateUserPlan(Guid id, [FromBody] UserPlanForUpdateDto UserPlan)
        // {
        //     if (UserPlan == null)
        //         return BadRequest("UserPlanForUpdateDto object is null");

        //     if (!ModelState.IsValid)
        //         return UnprocessableEntity(ModelState);

        //      _service.UserPlan.UpdateUserPlan(id, UserPlan, trackChanges: true);
        //     return NoContent();
        // }

        // /// <summary>
        // /// Patch Operations
        // /// Add, Replace, Remove
        // /// Copy, Move, Test
        // /// Properties within a Patch Request:
        // /// op: operation, path: path to the property, value: value to be used
        // [HttpPatch("{id:guid}")]
        // public  IActionResult PartiallyUpdateUserPlan(Guid id, [FromBody] JsonPatchDocument<UserPlanForUpdateDto> patchDocument)
        // {
        //     if (patchDocument is null)
        //         return BadRequest("patchDocument object sent from client is null");

        //     var result =  _service.UserPlan.GetUserPlanForPatch(id, trackChanges: true);
        //     patchDocument.ApplyTo(result.UserPlanForUpdate);

        //     TryValidateModel(result.UserPlanForUpdate);

        //     if (!ModelState.IsValid)
        //         return UnprocessableEntity(ModelState);

        //      _service.UserPlan.SaveChangesForPatch(result.UserPlanForUpdate, result.UserPlanEntity);

        //     return NoContent();
        // }

    }
}
