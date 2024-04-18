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
        (DeviceForUpdateDto DeviceForUpdate, Device DeviceEntity) GetDeviceForPatch(Guid DeviceId, bool trackChanges);
        IEnumerable<DeviceDto> GetDevicesFromUserPlan(Guid userId, Guid userPlanId, bool trackChanges);
        IEnumerable<DeviceDto> GetDevicesFromUser(Guid UserId, bool trackChanges);
        void SaveChangesForPatch(DeviceForUpdateDto DeviceForUpdate, Device DeviceEntity);

        void UpdateDevice(Guid id, DeviceForUpdateDto DeviceForUpdate, bool trackChanges);
    }
}
