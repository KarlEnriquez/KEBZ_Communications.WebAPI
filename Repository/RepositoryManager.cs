/*
 * Filename: RepositoryManager.cs
 * Description: This file contains the definition of the RepositoryManager repository class.
 * Implements IRepositoryManager
 */

using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IUserRepository> _userRepository;
        private readonly Lazy<IPlanRepository> _planRepository;
        private readonly Lazy<IDeviceRepository> _deviceRepository;
        private readonly Lazy<IUserPlanRepository> _userPlanRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(_repositoryContext));
            _planRepository = new Lazy<IPlanRepository>(() => new PlanRepository(_repositoryContext));
            _deviceRepository = new Lazy<IDeviceRepository>(() => new DeviceRepository(_repositoryContext));
            _userPlanRepository = new Lazy<IUserPlanRepository>(() => new UserPlanRepository(_repositoryContext));
        }

        public IUserRepository User => _userRepository.Value;

        public IDeviceRepository Device => _deviceRepository.Value;

        public IPlanRepository Plan => _planRepository.Value;

        public IUserPlanRepository UserPlan => _userPlanRepository.Value;

        public void Save() => _repositoryContext.SaveChanges();
    }
}
