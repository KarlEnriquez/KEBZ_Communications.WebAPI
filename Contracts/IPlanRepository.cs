﻿/*
 * Filename: IPlanRepository.cs
 * Description: This file contains the definition of the IPlanRepository contracts class.
 */

using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IPlanRepository
    {
        IEnumerable<Plan> GetAllPlans(bool trackChanges);
        Plan GetPlan(Guid id, bool trackChanges);
        void CreatePlan(Plan plan);
        void DeletePlan(Plan plan);
    }
}
