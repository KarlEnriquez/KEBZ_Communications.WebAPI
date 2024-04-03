using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KEBZ_Communications.WebAPI.Entities;

namespace Service.Contracts
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers(bool trackChanges);

    }
}
