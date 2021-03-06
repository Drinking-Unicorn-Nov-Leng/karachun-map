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
using karachun_map.Data.Entity;
using karachun_map.General.Expansions;
using karachun_map.Data.Filters;

namespace karachun_map.BI.Services
{
    public class Tours : ITours
    {
        private readonly IMapper _mapper;
        private readonly ServiceDbContext _context;

        public Tours(IMapper mapper, ServiceDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<bool> CreateTour(TourInputDto model)
        {
            var entity = _mapper.Map<Tour>(model);
            await _context.AddAsync(entity);

            if (await _context.SaveChangesAsync() > 0)
                return true;

            return false;
        }

        public async Task<bool> UpdateTour(TourInputDto model)
        {
            var entity = await _context.Tours.SingleOrDefaultAsync(x =>x.Id == model.Id);
            if (entity == null)
                return false;

            entity.Name = String.IsNullOrEmpty(model.Name) ? entity.Name : model.Name;
            entity.Pictures = model.Pictures.Count > 0 ? _mapper.Map<List<Data.Base.Attachment>, List<Data.Entity.Attachment>>(model.Pictures) : entity.Pictures;

            return true;
        }

        public async Task<TourOutputDto> Get(int id)
        {
            var entity = await GetTours.FirstOrDefaultAsync(x => x.Id == id);
            if (entity is null)
                return null;
            return _mapper.Map<TourOutputDto>(entity);
        }

        public async Task<IList<TourOutputDto>> GetAll(TourFilter filter)
        {
            var entity = GetTours.Filter(filter);

            return _mapper.Map<List<Tour>, List<TourOutputDto>>(await entity.ToListAsync());
        }

        #region GetTours

        private IQueryable<Tour> GetTours =>
                 _context.Tours
                            .Include(x => x.Places)
                            .Include(x => x.Avatar)
                            .Include(x => x.Pictures);

        #endregion
    }
}
