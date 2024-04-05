using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record UserDto(Guid UserId, string Username, string Email, string FirstName, string LastName, DateTime CreatedAt, Boolean status);
}
