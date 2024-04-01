/*
 * Filename: User.cs
 * Description: This file contains the definition of the User entity class.
 */

namespace KEBZ_Communications.WebAPI.Entities
{
    public class User
    {
        public int UserId {  get; set; }
        public string? Username {  get; set; }
        private string? Password { get; set; }
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime CreatedAt { get; set; }
        public Boolean status { get; set; }

        // Navigation property for 1-to-many relationshiip between User and Device
        public ICollection<Device>? Devices { get; set; }

        // Navigation property for many-to-many relationship between User and Plan 
        public ICollection<UserPlan>? UserPlans { get; set; }
    }
}
