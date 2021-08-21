using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using karachun_map.Data.Base;

namespace karachun_map.Data.Dto
{
    public class TourFilter : Filter
    {
        public int IncludePlaceId { get; set; }
    }
}
