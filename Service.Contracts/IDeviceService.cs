using Entities;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IDeviceService
    {
        // IEnumerable<Device> GetAllDevices(bool trackChanges);
        IEnumerable<DeviceDto> GetAllDevices(bool trackChanges);

        DeviceDto GetDevice(Guid id, bool trackChanges);
    }
}
