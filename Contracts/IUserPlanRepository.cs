/*
 * Filename: IUserPlanRepository.cs
 * Description: This file contains the definition of the IUserPlanRepository contracts class.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KEBZ_Communications.WebAPI.Entities;


namespace Contracts
{
    internal interface IUserPlanRepository
    {
        IEnumerable<UserPlan> GetAllUserPlans();
        UserPlan GetUserPlan(Guid id);
        void CreateUserPlan(UserPlan userPlan);
        void DeleteUserPlan(UserPlan userPlan);
    }
}
