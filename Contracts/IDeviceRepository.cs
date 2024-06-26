﻿/*
 * Filename: IDeviceRepository.cs
 * Description: This file contains the definition of the IDeviceRepository contracts class.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Contracts
{
    public interface IDeviceRepository
    {
        IEnumerable<Device> GetAllDevices(bool trackChanges);
        Device GetDevice(Guid id, bool trackChanges);
        void CreateDevice(Device device);
        void DeleteDevice(Device device);
        IEnumerable<Device> GetDevicesFromUserPlan(Guid userId, Guid userPlanId, bool trackChanges);
        IEnumerable<Device> GetDevicesFromUser(Guid UserId, bool trackChanges);
    }
}
