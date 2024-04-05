using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class UserNotFoundException : NotFoundException
    {
        public UserNotFoundException(Guid UserID) : base($"The user with the id: {UserID} does not exist in the database")
        {
        }
    }
}
