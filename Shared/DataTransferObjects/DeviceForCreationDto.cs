using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record DeviceForCreationDto
    {
        public Guid UserId { get; set;}
        public Guid UserPlanId { get; init; }
        public string? PhoneNumber { get; init; }
        public string? IMEI { get; init; }
        public string? Manufacturer { get; init; }
        public string? Model { get; init; }
    }
}
