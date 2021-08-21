using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using karachun_map.Data.Dto;
using karachun_map.Data.Base;

namespace karachun_map.BI.Interfaces
{
    public interface IAdmin
    {
        Task<bool> CreatePlace(PlaceInputDto place);

        Task<bool> UpdatePlace(PlaceInputDto place);

        Task<bool> RemovePlace(int id);
    }
}
