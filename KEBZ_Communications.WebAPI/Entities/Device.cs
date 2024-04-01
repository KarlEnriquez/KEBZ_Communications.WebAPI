/*
 * Filename: Device.cs
 * Description: This file contains the definition of the Device entity class.
 */

using System.Numerics;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KEBZ_Communications.WebAPI.Entities
{
    public class Device
    {
        public int DeviceId { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public string? PhoneNumber { get; set; }
        public string? IMEI { get; set; }
        public string? Manufacturer { get; set; }
        public string? Model { get; set; }

        public User? User { get; set; }
    }
}
