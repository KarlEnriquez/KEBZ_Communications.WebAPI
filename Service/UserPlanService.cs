using Service.Contracts;
using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KEBZ_Communications.WebAPI.Entities;

namespace Service
{
    public class UserPlanService : IUserPlanService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;

        public UserPlanService(IRepositoryManager repositoryManager, ILoggerManager logger)
        {
           _repositoryManager = repositoryManager;
           _logger = logger;
        }

        public IEnumerable<UserPlan> GetAllUserPlans(bool trackChanges){
            return _repositoryManager.UserPlan.GetAllUserPlans(trackChanges);
        }
    }
}