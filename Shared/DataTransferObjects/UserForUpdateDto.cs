using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record UserForUpdateDto : UserForManipulationDto
    {
        public Boolean status { get; set; }
        public ICollection<DeviceDto>? Devices { get; set; }
        public ICollection<UserPlanDto>? UserPlans { get; set; }
    }
}
