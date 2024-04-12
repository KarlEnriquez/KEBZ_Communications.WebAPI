/*
 * Filename: PlanRepository.cs
 * Description: This file contains the definition of the PlanRepository repository class.
 * Inherits RepositoryBase
 * Implements IPlanRepository
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
    public class PlanRepository : RepositoryBase<Plan>, IPlanRepository
    {
        public PlanRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<Plan> GetAllPlans(bool trackChanges) =>
            FindAll(trackChanges).OrderBy(s => s.PlanName).ToList();

        public Plan GetPlan(Guid planId, bool trackChanges) =>
            FindByCondition(s => s.PlanId.Equals(planId), trackChanges).SingleOrDefault();

        public void CreatePlan(Plan plan) => Create(plan);
        public void DeletePlan(Plan plan) => Delete(plan);
    }
}
