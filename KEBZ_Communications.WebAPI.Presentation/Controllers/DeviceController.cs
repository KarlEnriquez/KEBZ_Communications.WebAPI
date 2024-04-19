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
    public class DeviceController : ControllerBase
    {
        private readonly IServiceManager _service;

        public DeviceController(IServiceManager serviceManager) => _service = serviceManager;

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
        public IActionResult GetDevices()
        {
            var Devices = _service.Device.GetAllDevices(trackChanges: false);
            return Ok(Devices);
        }

        [HttpGet("{id:guid}", Name = "DeviceById")]
        public IActionResult GetDevice(Guid id)
        {
            var Device = _service.Device.GetDevice(id, trackChanges: false);
            return Ok(Device);

        }




        [HttpGet("{userId:guid}/{userPlanId:guid}", Name = "DevicesFromUserPlan")]
        public IActionResult GetDevicesFromUserPlan(Guid userId, Guid userPlanId)
        {
            var Devices = _service.Device.GetDevicesFromUserPlan(GetUserId(), userPlanId, trackChanges: false);
            return Ok(Devices);
        }

        [HttpGet("{userId:guid}/device", Name = "DevicesFromUser")]
        public IActionResult GetDevicesFromUser(Guid userId)
        {
            var Devices = _service.Device.GetDevicesFromUser(GetUserId(), trackChanges: false);
            return Ok(Devices);
        }



        [HttpPost]
        public IActionResult CreateDevice([FromBody] DeviceForCreationDto Device)
        {
            if (Device == null)
                return BadRequest("DeviceForCreationDto object is null");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            var createdDevice = _service.Device.CreateDevice(Device);
            if (createdDevice == null)
                return BadRequest("Error: Device could not be created, likely duplicate phone number");
            return CreatedAtRoute("DeviceById", new { id = createdDevice.DeviceId }, createdDevice);
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteDevice(Guid id)
        {
            _service.Device.DeleteDevice(id, trackChanges: false);
            return NoContent();
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpdateDevice(Guid id, [FromBody] DeviceForUpdateDto Device)
        {
            if (Device == null)
                return BadRequest("DeviceForUpdateDto object is null");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            _service.Device.UpdateDevice(id, Device, trackChanges: true);
            return NoContent();
        }

        /// <summary>
        /// Patch Operations
        /// Add, Replace, Remove
        /// Copy, Move, Test
        /// Properties within a Patch Request:
        /// op: operation, path: path to the property, value: value to be used
        [HttpPatch("{id:guid}")]
        public IActionResult PartiallyUpdateDevice(Guid id, [FromBody] JsonPatchDocument<DeviceForUpdateDto> patchDocument)
        {
            if (patchDocument is null)
                return BadRequest("patchDocument object sent from client is null");

            var result = _service.Device.GetDeviceForPatch(id, trackChanges: true);
            patchDocument.ApplyTo(result.DeviceForUpdate);

            TryValidateModel(result.DeviceForUpdate);

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            _service.Device.SaveChangesForPatch(result.DeviceForUpdate, result.DeviceEntity);

            return NoContent();
        }


    }
}
