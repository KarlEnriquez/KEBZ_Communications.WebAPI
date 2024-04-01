/*
 * Filename: IUserRepository.cs
 * Description: This file contains the definition of the IUserRepository contracts class.
 */

using KEBZ_Communications.WebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers(bool trackChanges);
        User GetUser(bool trackChanges);
        void CreateUser(User user);
        void DeleteUser(User user);
    }
}
