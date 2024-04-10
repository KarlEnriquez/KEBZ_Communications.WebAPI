/*
 * Filename: UserPlanRepository.cs
 * Description: This file contains the definition of the UserPlanRepository repository class.
 * Inherits RepositoryBase
 * Implements IUserPlanRepository
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class UserPlanRepository : RepositoryBase<UserPlan>, IUserPlanRepository
    {
        public UserPlanRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<UserPlan> GetAllUserPlans(Guid UserId, bool trackChanges) =>
            FindByCondition(e => e.UserId.Equals(UserId), trackChanges).ToList();

        public UserPlan GetUserPlan(Guid UserId, Guid id, bool trackChanges) =>
            FindByCondition(e => e.UserId.Equals(UserId) && e.UserPlanId.Equals(id), trackChanges).SingleOrDefault();

        public void CreateUserPlan(UserPlan UserPlan) => Create(UserPlan);
        public void DeleteUserPlan(UserPlan UserPlan) => Delete(UserPlan);
    }
}
