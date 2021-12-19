using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using API.Entities;
using AutoMapper;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Mention, MentionToReturnDto>()
            .ForMember(d => d.DataSource, o => o.MapFrom(s => s.DataSource.SourceName))
            .ForMember(d => d.AbpLanguage, o => o.MapFrom(s => s.Language.DisplayName))
            .ForMember(d => d.Product, o => o.MapFrom(s => s.Product.ProductName))
            .ForMember(d => d.Market, o => o.MapFrom(s => s.Market.Name))
            .ForMember(d => d.Region, o => o.MapFrom(s => s.Region.Name));
            
        }
    }
}