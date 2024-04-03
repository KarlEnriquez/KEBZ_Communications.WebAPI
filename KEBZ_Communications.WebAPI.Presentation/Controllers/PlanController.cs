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
    public class PlanController : ControllerBase
    {
        private readonly IServiceManager _service;

        public PlanController(IServiceManager serviceManager) => _service = serviceManager;


        [HttpGet]
        public IActionResult GetPlans()
        {
            var Plans = _service.Plan.GetAllPlans(trackChanges: false);
            return  Ok(Plans);
        }

    }
}
