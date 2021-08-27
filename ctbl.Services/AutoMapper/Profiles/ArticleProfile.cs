using System;
using AutoMapper;
using ctbl.Entities.Concrete;
using ctbl.Entities.Dtos.ArticleDtos;

namespace ctbl.Services.AutoMapper.Profiles
{
    public class ArticleProfile:Profile
    {
        public ArticleProfile()
        {
            CreateMap<ArticleAddDto,Article>().ForMember(dest => dest.CreatedDate,opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<ArticleUpdateDto, Article>().ForMember(dest => dest.ModifiedDate, opt =>opt.MapFrom(x => DateTime.Now));
        }
    }
}