using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    //public record UserDto(Guid UserId, string Username, string Email, string FirstName, string LastName, DateTime CreatedAt, Boolean status);

    public class UserDto
    {
        public Guid UserId { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime CreatedAt { get; set; }
        public Boolean status { get; set; }
    }
}
