using Service.Contracts;
using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using AutoMapper;
using Shared.DataTransferObjects;
using Entities.Exceptions;

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

        public void DeleteUserPlan(Guid UserId, Guid UserPlanId, bool trackChanges)
        {
            var UserPlan = _repositoryManager.UserPlan.GetUserPlan(UserId, UserPlanId, trackChanges);
            if (UserPlan == null)
                throw new UserPlanNotFoundException(UserId, UserPlanId);

            _repositoryManager.UserPlan.DeleteUserPlan(UserPlan);
            _repositoryManager.Save();
        }

        public UserPlanDto CreateUserPlan(UserPlanForCreationDto userPlan)
        {
            var student = _repositoryManager.User.GetUser(userPlan.UserId, false);
            if (student == null)
                throw new UserNotFoundException(userPlan.UserId);

            var course = _repositoryManager.Plan.GetPlan(userPlan.PlanId, false);
            if (course == null)
                throw new PlanNotFoundException(userPlan.PlanId);

            var userPlanEntity = _mapper.Map<UserPlan>(userPlan); // Mapping from DTO to Entity directly without assigning User or Plan
            _repositoryManager.UserPlan.CreateUserPlan(userPlanEntity);  // Directly create UserPlan without setting User and Plan entities
            _repositoryManager.Save();
            var userPlanToReturn = _mapper.Map<UserPlanDto>(userPlanEntity);
            return userPlanToReturn;
        }

        public IEnumerable<UserPlanDto> GetAllUserPlans(Guid UserId, bool trackChanges)
        {
            var UserPlans = _repositoryManager.UserPlan.GetAllUserPlans(UserId, trackChanges);
            var UserPlansDto = _mapper.Map<IEnumerable<UserPlanDto>>(UserPlans);
            return UserPlansDto;
        }

        public UserPlanDto GetUserPlan(Guid UserId, Guid id, bool trackChanges)
        {
            var User = _repositoryManager.User.GetUser(UserId, trackChanges);
            if (User == null)
                throw new UserNotFoundException(UserId);

            var UserPlan = _repositoryManager.UserPlan.GetUserPlan(UserId, id, trackChanges);
            if (UserPlan == null)
                throw new UserPlanNotFoundException(UserId, id);

            var UserPlanDto = _mapper.Map<UserPlanDto>(UserPlan);
            return UserPlanDto;
        }


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