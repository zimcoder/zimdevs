using AutoMapper;
using zimdevsapi.Models.DTOs;
using zimdevsapi.Models.Entities;

namespace zimdevsapi.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Developer, DeveloperDTO>();
            CreateMap<Blog, BlogDTO>();
        }
    }
}
