using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using karachun_map.BI.Interfaces;
using karachun_map.Data.Base;
using karachun_map.Data.Dto;
using karachun_map.Data.Enums;
using karachun_map.EF;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace karachun_map.BI.Services
{
    public class Places : IPlaces
    {
        private readonly IMapper _mapper;
        private readonly ServiceDbContext _context;

        public Places(IMapper mapper, ServiceDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<PlaceDto> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<PlaceDto>> GetAll(Filter filter)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<PlaceDto>> GetAllFull(Filter filter)
        {
            throw new NotImplementedException();
        }
    }
}
