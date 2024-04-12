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

         [HttpGet("{id:guid}", Name = "PlanById")]
         public  IActionResult GetPlan(Guid id)
         {
             var Plan =  _service.Plan.GetPlan(id, trackChanges: false);
             return Ok(Plan);
            
         }


        [HttpPost]
        public IActionResult CreatePlan([FromBody] PlanForCreationDto Plan)
        {
            if (Plan == null)
                return BadRequest("PlanForCreationDto object is null");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            var createdPlan = _service.Plan.CreatePlan(Plan);
            return CreatedAtRoute("PlanById", new { id = createdPlan.PlanId }, createdPlan);
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeletePlan(Guid id)
        {
            _service.Plan.DeletePlan(id, trackChanges: false);
            return NoContent();
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpdatePlan(Guid id, [FromBody] PlanForUpdateDto Plan)
        {
            if (Plan == null)
                return BadRequest("PlanForUpdateDto object is null");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            _service.Plan.UpdatePlan(id, Plan, trackChanges: true);
            return NoContent();
        }

        // /// <summary>
        // /// Patch Operations
        // /// Add, Replace, Remove
        // /// Copy, Move, Test
        // /// Properties within a Patch Request:
        // /// op: operation, path: path to the property, value: value to be used
        [HttpPatch("{id:guid}")]
        public IActionResult PartiallyUpdatePlan(Guid id, [FromBody] JsonPatchDocument<PlanForUpdateDto> patchDocument)
        {
            if (patchDocument is null)
                return BadRequest("patchDocument object sent from client is null");

            var result = _service.Plan.GetPlanForPatch(id, trackChanges: true);
            patchDocument.ApplyTo(result.PlanForUpdate);

            TryValidateModel(result.PlanForUpdate);

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            _service.Plan.SaveChangesForPatch(result.PlanForUpdate, result.PlanEntity);

            return NoContent();
        }


    }
}
