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
using karachun_map.Data.Filters;
using karachun_map.General.Expansions;

namespace karachun_map.BI.Services
{
    public class Places : IPlaces, IAdmin
    {
        private readonly IMapper _mapper;
        private readonly ServiceDbContext _context;

        public Places(IMapper mapper, ServiceDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<bool> CreatePlace(PlaceInputDto place)
        {
            var entity = _mapper.Map<Place>(place);
            await _context.AddAsync(entity);

            if (await _context.SaveChangesAsync() > 0)
                return true;

            return false;
        }

        public async Task<bool> RemovePlace(int id)
        {
            var entity = await GetPlaces.FirstOrDefaultAsync(x => x.Id == id);

            if (entity is null)
                return false;

            _context.Remove(entity);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdatePlace(PlaceInputDto place)
        {
            throw new NotImplementedException();
        }

        public async Task<PlaceOutputDto> Get(int id)
        {
            var entity = GetPlaces.FirstOrDefaultAsync(x => x.Id == id);
            if (entity is null)
                return null;
            return _mapper.Map<PlaceOutputDto>(entity);
        }

        public async Task<IList<PlaceSmallDto>> GetAll(PlaceFilter filter)
        {
            var entity = GetPlaces.Filter(filter);

            return _mapper.Map<List<Place>, List<PlaceSmallDto>>(await entity.ToListAsync());
        }

        public async Task<IList<PlaceOutputDto>> GetAllFull(PlaceFilter filter)
        {
            var entity = GetPlaces.Filter(filter);

            return _mapper.Map<List<Place>, List<PlaceOutputDto>>(await entity.ToListAsync());
        }

        #region GetPlaces

        private IQueryable<Place> GetPlaces =>
                 _context.Places
                            .Include(x => x.AudioGuide)
                            .Include(x => x.AudioHistory)
                            .Include(x => x.Avatar)
                            .Include(x => x.Pictures)
                            .Include(x => x.Coordinates);

        #endregion
    }
}
