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
    public class DeviceService : IDeviceService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;

        public DeviceService(IRepositoryManager repositoryManager, ILoggerManager logger)
        {
           _repositoryManager = repositoryManager;
           _logger = logger;
        }
        public IEnumerable<Device> GetAllDevices(bool trackChanges){
            return _repositoryManager.Device.GetAllDevices(trackChanges);
        }
    }
}
