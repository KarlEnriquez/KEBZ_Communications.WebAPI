/*
 * Filename: Device.cs
 * Description: This file contains the definition of the Device entity class.
 */

using System.Numerics;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Device
    {
        public Guid DeviceId { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        [ForeignKey(nameof(UserPlan))]
        public Guid UserPlanId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? PhoneNumber { get; set; }
        [MaxLength(15)] // IMEI is 15 digits long
        public string? IMEI { get; set; }
        public string? Manufacturer { get; set; }
        public string? Model { get; set; }

        public User? User { get; set; }
    }
}
