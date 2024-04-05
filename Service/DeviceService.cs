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
        // public DeviceDto CreateDevice(DeviceForCreationDto Device)
        // {
        //     var DeviceEntity = _mapper.Map<Device>(Device);
        //     _repositoryManager.Device.CreateDevice(DeviceEntity);
        //     _repositoryManager.Save();
        //     var DeviceToReturn = _mapper.Map<DeviceDto>(DeviceEntity);
        //     return DeviceToReturn;
        // }

        // public void DeleteDevice(Guid DeviceId, bool trackChanges)
        // {
        //     var Device = _repositoryManager.Device.GetDevice(DeviceId, trackChanges);
        //     if (Device == null)
        //         throw new DeviceNotFoundException(DeviceId);

        //     _repositoryManager.Device.DeleteDevice(Device);
        //     _repositoryManager.Save();
        // }


        // public IEnumerable<DeviceDto> GetAllDevices(bool trackChanges)
        // {
        //     var Devices = _repositoryManager.Device.GetAllDevices(trackChanges);
        //     var DevicesDto = _mapper.Map<IEnumerable<DeviceDto>>(Devices);
        //     return DevicesDto;
        // }

        // public DeviceDto GetDevice(Guid DeviceId, bool trackChanges)
        // {
        //     var Device = _repositoryManager.Device.GetDevice(DeviceId, trackChanges);
        //     if (Device == null)
        //         throw new DeviceNotFoundException(DeviceId);

        //     var DeviceDto = _mapper.Map<DeviceDto>(Device);

        //     return DeviceDto;
        // }


        // public (DeviceForUpdateDto DeviceForUpdate, Device DeviceEntity) GetDeviceForPatch(Guid DeviceId, bool trackChanges)
        // {
        //     var DeviceEntity = _repositoryManager.Device.GetDevice(DeviceId, trackChanges);
        //     if (DeviceEntity == null)
        //         throw new DeviceNotFoundException(DeviceId);

        //     var DeviceForUpdate = _mapper.Map<DeviceForUpdateDto>(DeviceEntity);
        //     return (DeviceForUpdate, DeviceEntity);
        // }

        // public void SaveChangesForPatch(DeviceForUpdateDto DeviceForUpdate, Device DeviceEntity)
        // {
        //     _mapper.Map(DeviceForUpdate, DeviceEntity);
        //     _repositoryManager.Save();
        // }

        // public void UpdateDevice(Guid id, DeviceForUpdateDto DeviceForUpdate, bool trackChanges)
        // {
        //     var DeviceEntity = _repositoryManager.Device.GetDevice(id, trackChanges);
        //     if (DeviceEntity == null)
        //         throw new DeviceNotFoundException(id);

        //     _mapper.Map(DeviceForUpdate, DeviceEntity);
        //     _repositoryManager.Save();
        // }
    }
}
