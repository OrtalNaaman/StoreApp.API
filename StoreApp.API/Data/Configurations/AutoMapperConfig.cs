using AutoMapper;
using StoreApp.API.Data.DTO;
using StoreApp.API.Data.Entities;

namespace StoreApp.API.Data.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<User, UserRegisterDTO>().ReverseMap();
        }
    }
}
