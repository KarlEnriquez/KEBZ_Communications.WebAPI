using Service.Contracts;
using Contracts;
using Entities;
using AutoMapper;
using Shared.DataTransferObjects;
using Entities.Exceptions;

namespace Service
{
    public class UserService : IUserService 
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public UserService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
            _mapper = mapper;
        }
        public UserDto CreateUser(UserForCreationDto User)
        {
            var UserEntity = _mapper.Map<User>(User);
            _repositoryManager.User.CreateUser(UserEntity);
            _repositoryManager.Save();
            var UserToReturn = _mapper.Map<UserDto>(UserEntity);
            return UserToReturn;
        }

        // public void DeleteUser(Guid UserId, bool trackChanges)
        // {
        //     var User = _repositoryManager.User.GetUser(UserId, trackChanges);
        //     if (User == null)
        //         throw new UserNotFoundException(UserId);

        //     _repositoryManager.User.DeleteUser(User);
        //     _repositoryManager.Save();
        // }

        public IEnumerable<UserDto> GetAllUsers(bool trackChanges)
        {
            var Users = _repositoryManager.User.GetAllUsers(trackChanges);
            var UsersDto = _mapper.Map<IEnumerable<UserDto>>(Users);
            return UsersDto;
        }

        public UserDto GetUser(Guid UserId, bool trackChanges)
        {
            var User = _repositoryManager.User.GetUser(UserId, trackChanges);
            if (User == null)
                throw new UserNotFoundException(UserId);

            var UserDto = _mapper.Map<UserDto>(User);

            return UserDto;
        }


        // public (UserForUpdateDto UserForUpdate, User UserEntity) GetUserForPatch(Guid UserId, bool trackChanges)
        // {
        //     var UserEntity = _repositoryManager.User.GetUser(UserId, trackChanges);
        //     if (UserEntity == null)
        //         throw new UserNotFoundException(UserId);

        //     var UserForUpdate = _mapper.Map<UserForUpdateDto>(UserEntity);
        //     return (UserForUpdate, UserEntity);
        // }

        // public void SaveChangesForPatch(UserForUpdateDto UserForUpdate, User UserEntity)
        // {
        //     _mapper.Map(UserForUpdate, UserEntity);
        //     _repositoryManager.Save();
        // }

        // public void UpdateUser(Guid id, UserForUpdateDto UserForUpdate, bool trackChanges)
        // {
        //     var UserEntity = _repositoryManager.User.GetUser(id, trackChanges);
        //     if (UserEntity == null)
        //         throw new UserNotFoundException(id);

        //     _mapper.Map(UserForUpdate, UserEntity);
        //     _repositoryManager.Save();
        // }
    }
}
