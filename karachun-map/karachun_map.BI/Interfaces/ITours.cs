using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using karachun_map.Data.Dto;
using karachun_map.Data.Filters;

namespace karachun_map.BI.Interfaces
{
    public interface ITours
    {
        Task<bool> CreateTour(TourInputDto model);

        Task<bool> UpdateTour(TourInputDto model);

        Task<TourOutputDto> Get(int id);

        Task<IList<TourOutputDto>> GetAll(TourFilter filter);
    }
}
