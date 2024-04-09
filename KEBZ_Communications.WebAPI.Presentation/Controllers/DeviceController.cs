using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Microsoft.AspNetCore.JsonPatch;

namespace KEBZ_Communications.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // Attribute routing, Auto 400 response, binding source parameter, multi-part/form-data inference, problem details for status codes
    public class DeviceController : ControllerBase
    {
        private readonly IServiceManager _service;

        public DeviceController(IServiceManager serviceManager) => _service = serviceManager;


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


        // [HttpPost]
        // public  IActionResult CreateDevice([FromBody] DeviceForCreationDto Device)
        // {
        //     if (Device == null)
        //         return BadRequest("DeviceForCreationDto object is null");

        //     if (!ModelState.IsValid)
        //         return UnprocessableEntity(ModelState);

        //     var createdDevice =  _service.Device.CreateDevice(Device);
        //     return CreatedAtRoute("DeviceById", new { id = createdDevice.Id }, createdDevice);
        // }

        // [HttpDelete("{id:guid}")]
        // public  IActionResult DeleteDevice(Guid id)
        // {
        //      _service.Device.DeleteDevice(id, trackChanges: false);
        //     return NoContent();
        // }

        // [HttpPut("{id:guid}")]
        // public  IActionResult UpdateDevice(Guid id, [FromBody] DeviceForUpdateDto Device)
        // {
        //     if (Device == null)
        //         return BadRequest("DeviceForUpdateDto object is null");

        //     if (!ModelState.IsValid)
        //         return UnprocessableEntity(ModelState);

        //      _service.Device.UpdateDevice(id, Device, trackChanges: true);
        //     return NoContent();
        // }

        // /// <summary>
        // /// Patch Operations
        // /// Add, Replace, Remove
        // /// Copy, Move, Test
        // /// Properties within a Patch Request:
        // /// op: operation, path: path to the property, value: value to be used
        // [HttpPatch("{id:guid}")]
        // public  IActionResult PartiallyUpdateDevice(Guid id, [FromBody] JsonPatchDocument<DeviceForUpdateDto> patchDocument)
        // {
        //     if (patchDocument is null)
        //         return BadRequest("patchDocument object sent from client is null");

        //     var result =  _service.Device.GetDeviceForPatch(id, trackChanges: true);
        //     patchDocument.ApplyTo(result.DeviceForUpdate);

        //     TryValidateModel(result.DeviceForUpdate);

        //     if (!ModelState.IsValid)
        //         return UnprocessableEntity(ModelState);

        //      _service.Device.SaveChangesForPatch(result.DeviceForUpdate, result.DeviceEntity);

        //     return NoContent();
        // }


    }
}
