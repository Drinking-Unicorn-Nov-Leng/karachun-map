using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using karachun_map.Data.Base;
using karachun_map.Data.Entity;
using System.Linq.Expressions;

namespace karachun_map.Data.Filters
{
    public class TourFilter : FilterEntity<Tour>
    {
        public int IncludePlaceId { get; set; }

        public override Expression<Func<Tour, bool>> Build() => IncludePlaceId > 0 ? x => x.Places.Any(y => y.Id == IncludePlaceId) : base.Build();
    }
}
