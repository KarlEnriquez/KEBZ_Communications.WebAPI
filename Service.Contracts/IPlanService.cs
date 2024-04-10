using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IPlanService
    {
        IEnumerable<PlanDto> GetAllPlans(bool trackChanges);

        PlanDto GetPlan(Guid id, bool trackChanges);

        PlanDto CreatePlan(PlanForCreationDto Plan);

        //void UpdatePlan(Plan plan);

        //void DeletePlan(Plan plan);
    }
}
