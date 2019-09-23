using System.Linq;
using AutoMapper;
using SalsaSocialize.Dtos;
using SalsaSocialize.Models;

namespace SalsaSocialize.Helpers
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User,UserForListDto>()
            .ForMember(dest=>dest.PhotoUrl,opt=>opt.MapFrom(src=>
            src.Photos.FirstOrDefault(p=>p.IsMain).Url))
            .ForMember(dest=>dest.Age,opt=>opt.MapFrom(src=>src.DateOfBirth.CalculateAge()));
            
            CreateMap<User,UserForDetailDto>()
            .ForMember(dest=>dest.PhotoUrl,opt=>opt.MapFrom(src=>
            src.Photos.FirstOrDefault(p=>p.IsMain).Url))
            .ForMember(dest=>dest.Age,opt=>opt.MapFrom(src=>src.DateOfBirth.CalculateAge()));
            
            CreateMap<Photo,PhotosForDetailDto>();

            CreateMap<UserForUpdateDto,User>();
        }
    }
}