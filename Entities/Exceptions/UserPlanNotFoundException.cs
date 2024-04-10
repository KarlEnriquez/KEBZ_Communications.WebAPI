using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class UserPlanNotFoundException : NotFoundException
    {
        public UserPlanNotFoundException(Guid UserId, Guid UserPlanID) : base($"The user id: {UserId} with the user plan with the id: {UserPlanID} does not exist in the database")
        {
        }
    }
}
