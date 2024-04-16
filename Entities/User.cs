/*
 * Filename: User.cs
 * Description: This file contains the definition of the User entity class.
 */
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Entities
{
    public class User: IdentityUser<Guid>

    {
        [Key]
        public override Guid Id {  get; set; }
        public override string? UserName {  get; set; }
        public override string? Email { get; set; }
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
