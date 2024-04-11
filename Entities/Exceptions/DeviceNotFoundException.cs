using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class DeviceNotFoundException : NotFoundException
    {
        public DeviceNotFoundException(Guid DeviceID) : base($"The device with the id: {DeviceID} does not exist in the database")
        {
        }
    }
}
