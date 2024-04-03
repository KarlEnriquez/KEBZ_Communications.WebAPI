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
            return  Ok(Devices);
        }

    }
}
