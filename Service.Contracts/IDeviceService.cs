using Entities;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IDeviceService
    {
        DeviceDto CreateDevice(DeviceForCreationDto Device);
        void DeleteDevice(Guid DeviceId, bool trackChanges);
        IEnumerable<DeviceDto> GetAllDevices(bool trackChanges);

        DeviceDto GetDevice(Guid id, bool trackChanges);
    }
}
