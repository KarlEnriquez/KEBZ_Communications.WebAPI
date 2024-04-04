using Service.Contracts;
using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KEBZ_Communications.WebAPI.Entities;
using AutoMapper;

namespace Service
{
    public class UserPlanService : IUserPlanService 
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;

        private readonly IMapper _mapper;


        public UserPlanService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
           _repositoryManager = repositoryManager;
           _logger = logger;
           _mapper = mapper;
        }

        // public UserPlanDto CreateUserPlan(UserPlanForCreationDto UserPlan)
        // {
        //     var UserPlanEntity = _mapper.Map<UserPlan>(UserPlan);
        //     _repositoryManager.UserPlan.CreateUserPlan(UserPlanEntity);
        //     _repositoryManager.Save();
        //     var UserPlanToReturn = _mapper.Map<UserPlanDto>(UserPlanEntity);
        //     return UserPlanToReturn;
        // }

        // public void DeleteUserPlan(Guid UserPlanId, bool trackChanges)
        // {
        //     var UserPlan = _repositoryManager.UserPlan.GetUserPlan(UserPlanId, trackChanges);
        //     if (UserPlan == null)
        //         throw new UserPlanNotFoundException(UserPlanId);

        //     _repositoryManager.UserPlan.DeleteUserPlan(UserPlan);
        //     _repositoryManager.Save();
        // }


        // public IEnumerable<UserPlanDto> GetAllUserPlans(bool trackChanges)
        // {
        //     var UserPlans = _repositoryManager.UserPlan.GetAllUserPlans(trackChanges);
        //     var UserPlansDto = _mapper.Map<IEnumerable<UserPlanDto>>(UserPlans);
        //     return UserPlansDto;
        // }

        // public UserPlanDto GetUserPlan(Guid UserPlanId, bool trackChanges)
        // {
        //     var UserPlan = _repositoryManager.UserPlan.GetUserPlan(UserPlanId, trackChanges);
        //     if (UserPlan == null)
        //         throw new UserPlanNotFoundException(UserPlanId);

        //     var UserPlanDto = _mapper.Map<UserPlanDto>(UserPlan);

        //     return UserPlanDto;
        // }


        // public (UserPlanForUpdateDto UserPlanForUpdate, UserPlan UserPlanEntity) GetUserPlanForPatch(Guid UserPlanId, bool trackChanges)
        // {
        //     var UserPlanEntity = _repositoryManager.UserPlan.GetUserPlan(UserPlanId, trackChanges);
        //     if (UserPlanEntity == null)
        //         throw new UserPlanNotFoundException(UserPlanId);

        //     var UserPlanForUpdate = _mapper.Map<UserPlanForUpdateDto>(UserPlanEntity);
        //     return (UserPlanForUpdate, UserPlanEntity);
        // }

        // public void SaveChangesForPatch(UserPlanForUpdateDto UserPlanForUpdate, UserPlan UserPlanEntity)
        // {
        //     _mapper.Map(UserPlanForUpdate, UserPlanEntity);
        //     _repositoryManager.Save();
        // }

        // public void UpdateUserPlan(Guid id, UserPlanForUpdateDto UserPlanForUpdate, bool trackChanges)
        // {
        //     var UserPlanEntity = _repositoryManager.UserPlan.GetUserPlan(id, trackChanges);
        //     if (UserPlanEntity == null)
        //         throw new UserPlanNotFoundException(id);

        //     _mapper.Map(UserPlanForUpdate, UserPlanEntity);
        //     _repositoryManager.Save();
        // }
    }
}