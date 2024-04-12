/*
 * Filename: DeviceRepository.cs
 * Description: This file contains the definition of the DeviceRepository repository class.
 * Inherits RepositoryBase
 * Implements IDeviceRepository
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class DeviceRepository : RepositoryBase<Device>, IDeviceRepository
    {
        public DeviceRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<Device> GetAllDevices(bool trackChanges) =>
            FindAll(trackChanges).OrderBy(s => s.DeviceId).ToList();

        public IEnumerable<Device> GetDevicesFromUserPlan(Guid UserId, Guid UserPlanId, bool trackChanges) =>
            FindByCondition(s => s.UserId.Equals(UserId) && s.UserPlanId.Equals(UserPlanId), trackChanges).ToList();
        public Device GetDevice(Guid deviceId, bool trackChanges) =>
            FindByCondition(s => s.DeviceId.Equals(deviceId), trackChanges).SingleOrDefault();

        public void CreateDevice(Device device) => Create(device);
        public void DeleteDevice(Device device) => Delete(device);
    }
}
