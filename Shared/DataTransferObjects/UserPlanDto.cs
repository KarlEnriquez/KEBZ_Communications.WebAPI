using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public class UserPlanDto
    {
        public Guid UserId { get; set; }
        public Guid PlanId { get; set; }
        public UserDto? User { get; set; }

        public PlanDto? Plan { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
