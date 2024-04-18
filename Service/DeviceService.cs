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
using Microsoft.EntityFrameworkCore;
using Entities.Exceptions;

namespace Service
{
    public class DeviceService : IDeviceService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        

        public DeviceService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
            _mapper = mapper;
        }
        public DeviceDto CreateDevice(DeviceForCreationDto Device)
        {
            var DeviceEntity = _mapper.Map<Device>(Device);
            _repositoryManager.Device.CreateDevice(DeviceEntity);
            try
            {
                _repositoryManager.Save();
            }catch (DbUpdateException ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                return null;
                throw new Exception("\n\n\n\n dbupdate exceiton \n\n\n\n");
            }catch(Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                return null;
                throw new Exception("\n\n\n\n exceiton \n\n\n\n");
            }

            var DeviceToReturn = _mapper.Map<DeviceDto>(DeviceEntity);
            return DeviceToReturn;
        }

        public void DeleteDevice(Guid DeviceId, bool trackChanges)
        {
            var Device = _repositoryManager.Device.GetDevice(DeviceId, trackChanges);
            if (Device == null)
                throw new DeviceNotFoundException(DeviceId);

            _repositoryManager.Device.DeleteDevice(Device);
            _repositoryManager.Save();
        }

        public IEnumerable<DeviceDto> GetAllDevices(bool trackChanges)
        {
            var Devices = _repositoryManager.Device.GetAllDevices(trackChanges);
            var DevicesDto = _mapper.Map<IEnumerable<DeviceDto>>(Devices);
            return DevicesDto;
        }

        public DeviceDto GetDevice(Guid DeviceId, bool trackChanges)
        {
            var Device = _repositoryManager.Device.GetDevice(DeviceId, trackChanges);
            if (Device == null)
                throw new DeviceNotFoundException(DeviceId);

            var DeviceDto = _mapper.Map<DeviceDto>(Device);

            return DeviceDto;
        }


        public IEnumerable<DeviceDto> GetDevicesFromUserPlan(Guid UserId, Guid UserPlanId, bool trackChanges)
        {
            var Devices = _repositoryManager.Device.GetDevicesFromUserPlan(UserId, UserPlanId, trackChanges);
            var DevicesDto = _mapper.Map<IEnumerable<DeviceDto>>(Devices);
            return DevicesDto;
        }

        public IEnumerable<DeviceDto> GetDevicesFromUser(Guid UserId, bool trackChanges)
        {
            var Devices = _repositoryManager.Device.GetDevicesFromUser(UserId, trackChanges);
            var DevicesDto = _mapper.Map<IEnumerable<DeviceDto>>(Devices);
            return DevicesDto;
        }

        public (DeviceForUpdateDto DeviceForUpdate, Device DeviceEntity) GetDeviceForPatch(Guid DeviceId, bool trackChanges)
        {
            var DeviceEntity = _repositoryManager.Device.GetDevice(DeviceId, trackChanges);
            if (DeviceEntity == null)
                throw new DeviceNotFoundException(DeviceId);

            var DeviceForUpdate = _mapper.Map<DeviceForUpdateDto>(DeviceEntity);
            return (DeviceForUpdate, DeviceEntity);
        }

        public void SaveChangesForPatch(DeviceForUpdateDto DeviceForUpdate, Device DeviceEntity)
        {
            _mapper.Map(DeviceForUpdate, DeviceEntity);
            _repositoryManager.Save();
        }

        public void UpdateDevice(Guid id, DeviceForUpdateDto DeviceForUpdate, bool trackChanges)
        {
            var DeviceEntity = _repositoryManager.Device.GetDevice(id, trackChanges);
            if (DeviceEntity == null)
                throw new DeviceNotFoundException(id);

            _mapper.Map(DeviceForUpdate, DeviceEntity);
            _repositoryManager.Save();
        }
    }
}
