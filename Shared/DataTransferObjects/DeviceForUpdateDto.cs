using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record DeviceForUpdateDto
    {
        public string? PhoneNumber { get; set; }
        public string? IMEI { get; set; }
    }
}
