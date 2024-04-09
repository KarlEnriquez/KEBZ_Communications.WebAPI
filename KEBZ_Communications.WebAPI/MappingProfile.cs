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
            CreateMap<Device, DeviceDto>();
            CreateMap<Plan, PlanDto>();
            CreateMap<UserPlan, UserPlanDto>();
            CreateMap<UserForCreationDto, User>();
            CreateMap<UserForUpdateDto, User>().ReverseMap();
            CreateMap<DeviceForCreationDto, Device>();

        }
    }
}
