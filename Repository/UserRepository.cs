/*
 * Filename: UserRepository.cs
 * Description: This file contains the definition of the UserRepository repository class.
 * Inherits RepositoryBase
 * Implements IUserRepository
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using KEBZ_Communications.WebAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<User> GetAllUsers(bool trackChanges) =>
            FindAll(trackChanges).OrderBy(s => s.LastName).ToList();

        public User GetUser(Guid userId, bool trackChanges) =>
            FindByCondition(s => s.UserId.Equals(userId), trackChanges).SingleOrDefault();

        public void CreateUser(User user) => Create(user);
        public void DeleteUser(User user) => Delete(user);
    }
}
