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

        public IEnumerable<UserPlan> GetAllUserPlans(bool trackChanges) =>
            FindAll(trackChanges).OrderBy(s => s.UserId).ToList();

        public UserPlan GetUserPlan(Guid userId, bool trackChanges) =>
            FindByCondition(s => s.UserId.Equals(userId), trackChanges).SingleOrDefault();

        public void CreateUserPlan(UserPlan UserPlan) => Create(UserPlan);
        public void DeleteUserPlan(UserPlan UserPlan) => Delete(UserPlan);
    }
}
