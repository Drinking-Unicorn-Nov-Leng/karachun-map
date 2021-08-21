using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using karachun_map.Data.Dto;
using karachun_map.Data.Base;

namespace karachun_map.BI.Interfaces
{
    public interface IPlaces
    {
        Task<PlaceDto> Get(int id);

        Task<IList<PlaceDto>> GetAll(Filter filter);

        Task<IList<PlaceDto>> GetAllFull(Filter filter);
    }
}
