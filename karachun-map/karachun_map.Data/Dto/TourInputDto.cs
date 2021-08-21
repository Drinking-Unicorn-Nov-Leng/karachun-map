using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using karachun_map.Data.Base;
using karachun_map.Data.Enums;

namespace karachun_map.Data.Dto
{
    public class TourInputDto
    {
        public int? Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public PointType Type { get; set; }

        public int[] PlacesIds { get; set; }

        public Attachment Avatar { get; set; }

        public List<Attachment> Pictures { get; set; }
    }
}
