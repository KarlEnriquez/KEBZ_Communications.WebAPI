using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IServiceManager
    {
        IUserService User { get; }
        IUserPlanService UserPlan { get; }
        IPlanService Plan { get; }
        IDeviceService Device { get; }
        IAuthenticationService Authentication { get; }

    }
}
