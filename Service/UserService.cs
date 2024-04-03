using Service.Contracts;
using Contracts;
using KEBZ_Communications.WebAPI.Entities;

namespace Service
{
    public class UserService : IUserService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;

        public UserService(IRepositoryManager repositoryManager, ILoggerManager logger)
        {
           _repositoryManager = repositoryManager;
           _logger = logger;
        }
        public IEnumerable<User> GetAllUsers(bool trackChanges){
            return _repositoryManager.User.GetAllUsers(trackChanges);
        }
    }
}
