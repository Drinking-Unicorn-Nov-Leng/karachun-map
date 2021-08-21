using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using karachun_map.Data.Dto;
using karachun_map.Data.Base;
using karachun_map.Data.Filters;

namespace karachun_map.BI.Interfaces
{
    public interface IPlaces
    {
        Task<PlaceOutputDto> Get(int id);

        Task<IList<PlaceSmallDto>> GetAll(PlaceFilter filter);

        Task<IList<PlaceOutputDto>> GetAllFull(PlaceFilter filter);
    }
}
