/*
 * Filename: IUserPlanRepository.cs
 * Description: This file contains the definition of the IUserPlanRepository contracts class.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;


namespace Contracts
{
    public interface IUserPlanRepository
    {
        IEnumerable<UserPlan> GetAllUserPlans(Guid UserId, bool trackChanges);
        UserPlan GetUserPlan(Guid UserId, Guid id, bool trackChanges);
        void CreateUserPlan(UserPlan userPlan);
        void DeleteUserPlan(UserPlan userPlan);
    }
}
