using System;
using AutoMapper;
using ctbl.Entities.Concrete;
using ctbl.Entities.Dtos.CategoryDtos;

namespace ctbl.Services.AutoMapper.Profiles
{
    public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryAddDto, Category>()
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<CategoryUpdateDto, Category>().ForMember(dest => dest.ModifiedDate, opt=> opt.MapFrom(x => DateTime.Now));
        }
    }
}