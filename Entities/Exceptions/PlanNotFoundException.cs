using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class PlanNotFoundException : NotFoundException
    {
        public PlanNotFoundException(Guid PlanID) : base($"The plan with the id: {PlanID} does not exist in the database")
        {
        }
    }
}
