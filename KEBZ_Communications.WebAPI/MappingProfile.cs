using AutoMapper;
using Entities;
using Shared.DataTransferObjects;

namespace KEBZ_Communications.WebAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>();

        }
    }
}
