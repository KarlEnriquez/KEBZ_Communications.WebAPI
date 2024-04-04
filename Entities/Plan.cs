/*
 * Filename: Plan.cs
 * Description: This file contains the definition of the Plan entity class.
 */

using System.ComponentModel.DataAnnotations.Schema;

namespace KEBZ_Communications.WebAPI.Entities
{
    public class Plan
    {
        public Guid PlanId { get; set; }
        public string? PlanName { get; set; }
        public string? PlanDescription { get; set; }
        
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }
        public int DeviceLimit { get; set; }
        public int DataLimit { get; set; }
        public int MinuteLimit { get; set; }
        public int TextLimit { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation property for many-to-many relationship with User
        // 
        public ICollection<UserPlan>? UserPlans { get; set; }
    }
}
