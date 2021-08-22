using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using karachun_map.Data.Base;
using karachun_map.Data.Enums;

namespace karachun_map.Data.Dto
{
    public class PlaceSmallDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string SmallDescription { get; set; }

        public PointType Type { get; set; }

        public Coordinates Coordinates { get; set; }

        public string Avatar { get; set; }
    }
}
