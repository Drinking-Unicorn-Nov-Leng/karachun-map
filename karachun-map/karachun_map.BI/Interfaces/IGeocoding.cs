using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using karachun_map.Data.Base;

namespace karachun_map.BI.Interfaces
{
    public interface IGeocoding
    {
        Task<int> GetObjectsNearby(Coordinates coordinates);
    }
}
