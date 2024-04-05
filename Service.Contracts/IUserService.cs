using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IUserService
    {
        IEnumerable<UserDto> GetAllUsers(bool trackChanges);

    }
}
