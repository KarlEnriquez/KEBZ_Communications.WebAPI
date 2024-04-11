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
        UserDto CreateUser(UserForCreationDto userDto);
        void DeleteUser(Guid userId, bool trackChanges);
        IEnumerable<UserDto> GetAllUsers(bool trackChanges);

        UserDto GetUser(Guid id, bool trackChanges);
        (UserForUpdateDto UserForUpdate, User UserEntity) GetUserForPatch(Guid UserId, bool trackChanges);
        void SaveChangesForPatch(UserForUpdateDto UserForUpdate, User UserEntity);
        void UpdateUser(Guid id, UserForUpdateDto UserForUpdate, bool trackChanges);

    }
}
