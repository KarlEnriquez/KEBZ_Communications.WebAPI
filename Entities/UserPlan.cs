/*
 * Filename: UserPlan.cs
 * Description: This file contains the definition of the UserPlan entity class.
 */

using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class UserPlan
    {
        public Guid UserPlanId { get; set; }
        public Guid UserId { get; set; }
        public Guid PlanId { get; set; }

        public User? User { get; set; }
        public Plan? Plan { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
