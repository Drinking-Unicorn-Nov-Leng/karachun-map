using AutoMapper;
using AutoMapper.EquivalencyExpression;
using karachun_map.Data;
using karachun_map.Data.Entity;
using System;
using System.Linq;

namespace karachun_map.API.Configurations.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // CreateMap<ClassDTO, ClassEntity>();
        }
    }
}
