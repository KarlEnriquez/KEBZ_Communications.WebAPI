using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Contracts;
using Contracts;
using Entities;
using AutoMapper;
using Shared.DataTransferObjects;
using Entities.Exceptions;

namespace Service
{
    public class PlanService : IPlanService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public PlanService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
            _mapper = mapper;
        }
        public PlanDto CreatePlan(PlanForCreationDto Plan)
        {
            var PlanEntity = _mapper.Map<Plan>(Plan);
            _repositoryManager.Plan.CreatePlan(PlanEntity);
            _repositoryManager.Save();
            var PlanToReturn = _mapper.Map<PlanDto>(PlanEntity);
            return PlanToReturn;
        }

        public void DeletePlan(Guid PlanId, bool trackChanges)
        {
            var Plan = _repositoryManager.Plan.GetPlan(PlanId, trackChanges);
            if (Plan == null)
                throw new PlanNotFoundException(PlanId);

            _repositoryManager.Plan.DeletePlan(Plan);
            _repositoryManager.Save();
        }


        public IEnumerable<PlanDto> GetAllPlans(bool trackChanges)
        {
            var Plans = _repositoryManager.Plan.GetAllPlans(trackChanges);
            var PlansDto = _mapper.Map<IEnumerable<PlanDto>>(Plans);
            return PlansDto;
        }

        public PlanDto GetPlan(Guid PlanId, bool trackChanges)
        {
            var Plan = _repositoryManager.Plan.GetPlan(PlanId, trackChanges);
            if (Plan == null)
                throw new PlanNotFoundException(PlanId);

            var PlanDto = _mapper.Map<PlanDto>(Plan);

            return PlanDto;
        }


        // public (PlanForUpdateDto PlanForUpdate, Plan PlanEntity) GetPlanForPatch(Guid PlanId, bool trackChanges)
        // {
        //     var PlanEntity = _repositoryManager.Plan.GetPlan(PlanId, trackChanges);
        //     if (PlanEntity == null)
        //         throw new PlanNotFoundException(PlanId);

        //     var PlanForUpdate = _mapper.Map<PlanForUpdateDto>(PlanEntity);
        //     return (PlanForUpdate, PlanEntity);
        // }

        // public void SaveChangesForPatch(PlanForUpdateDto PlanForUpdate, Plan PlanEntity)
        // {
        //     _mapper.Map(PlanForUpdate, PlanEntity);
        //     _repositoryManager.Save();
        // }

        public void UpdatePlan(Guid id, PlanForUpdateDto PlanForUpdate, bool trackChanges)
        {
            var PlanEntity = _repositoryManager.Plan.GetPlan(id, trackChanges);
            if (PlanEntity == null)
                throw new PlanNotFoundException(id);

            _mapper.Map(PlanForUpdate, PlanEntity);
            _repositoryManager.Save();
        }
    }
}
