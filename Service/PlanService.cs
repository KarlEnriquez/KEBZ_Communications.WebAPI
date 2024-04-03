using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Contracts;
using Contracts;
using KEBZ_Communications.WebAPI.Entities;


namespace Service
{
    public class PlanService : IPlanService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;

        public PlanService(IRepositoryManager repositoryManager, ILoggerManager logger)
        {
           _repositoryManager = repositoryManager;
           _logger = logger;
        }
        public IEnumerable<Plan> GetAllPlans(bool trackChanges){
            return _repositoryManager.Plan.GetAllPlans(trackChanges);
        }
    }
}
