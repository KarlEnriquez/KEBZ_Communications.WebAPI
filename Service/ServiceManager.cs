using Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Service
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IUserService> _userService;
        private readonly Lazy<IUserPlanService> _userPlanService;
        private readonly Lazy<IPlanService> _planService;
        private readonly Lazy<IDeviceService> _deviceService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager loggerManager, IMapper mapperManger)
        {
            _userService = new Lazy<IUserService>(() => new UserService(repositoryManager, loggerManager, mapperManger));
            _userPlanService = new Lazy<IUserPlanService>(() => new UserPlanService(repositoryManager, loggerManager, mapperManger));
            _planService = new Lazy<IPlanService>(() => new PlanService(repositoryManager, loggerManager, mapperManger));
            _deviceService = new Lazy<IDeviceService>(() => new DeviceService(repositoryManager, loggerManager, mapperManger));
        }

        public IUserService User => _userService.Value;

        public IUserPlanService UserPlan => _userPlanService.Value;

        public IPlanService Plan => _planService.Value;

        public IDeviceService Device => _deviceService.Value;
    }
}
