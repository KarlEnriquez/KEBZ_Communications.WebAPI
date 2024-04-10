using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IUserPlanService
    {
        IEnumerable<UserPlanDto> GetAllUserPlans(Guid UserId, bool trackChanges);

        UserPlanDto GetUserPlan(Guid UserId, Guid UserPlanId, bool trackChanges);

        UserPlanDto CreateUserPlan(UserPlanForCreationDto UserPlan);

    }
}
