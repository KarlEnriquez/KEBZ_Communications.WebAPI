using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KEBZ_Communications.WebAPI.Entities;

namespace Service.Contracts
{
    public interface IPlanService
    {
        IEnumerable<Plan> GetAllPlans(bool trackChanges);
    }
}
