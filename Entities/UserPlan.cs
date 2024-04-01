/*
 * Filename: UserPlan.cs
 * Description: This file contains the definition of the UserPlan entity class.
 */

using System.ComponentModel.DataAnnotations;

namespace KEBZ_Communications.WebAPI.Entities
{
    public class UserPlan
    {
        public int UserId { get; set; }
        public int PlanId { get; set; }

        public User? User { get; set; }
        public Plan? Plan { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
