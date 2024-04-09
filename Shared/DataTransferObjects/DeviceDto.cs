using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public class DeviceDto
    {
        public Guid DeviceId { get; set; }
        public Guid UserId { get; set; }
        public string? PhoneNumber { get; set; }
        public string? IMEI { get; set; }
        public string? Manufacturer { get; set; }
        public string? Model { get; set; }
        public UserDto? User { get; set; }
    }
}
