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

        (PlanForUpdateDto PlanForUpdate, Plan PlanEntity) GetPlanForPatch(Guid PlanId, bool trackChanges);
        void SaveChangesForPatch(PlanForUpdateDto PlanForUpdate, Plan PlanEntity);

        void UpdatePlan(Guid id, PlanForUpdateDto PlanForUpdate, bool trackChanges);

        void DeletePlan(Guid PlanId, bool trackChanges);
    }
}
