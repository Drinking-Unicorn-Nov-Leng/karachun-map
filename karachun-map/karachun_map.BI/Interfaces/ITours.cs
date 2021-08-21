using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using karachun_map.Data.Dto;

namespace karachun_map.BI.Interfaces
{
    public interface ITours
    {
        Task<bool> Add();

        Task<bool> Update();

        Task<bool> Get(int id);

        Task<bool> GetAll(TourFilter filter);
    }
}
