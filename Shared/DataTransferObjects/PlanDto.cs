using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public class PlanDto
    {
        public Guid PlanId { get; set; }
        public string? PlanName { get; set; }
        public string? PlanDescription { get; set; }
        public decimal Price { get; set; }
        public int DeviceLimit { get; set; }
        public int DataLimit { get; set; }
        public int MinuteLimit { get; set; }
        public int TextLimit { get; set; }
        public DateTime CreatedAt { get; set; }
    }   
}
