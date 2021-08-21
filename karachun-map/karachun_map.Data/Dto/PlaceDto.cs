using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using karachun_map.Data.Base;

namespace karachun_map.Data.Dto
{
    public class PlaceDto
    {
        public int? Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string SmallDescription { get; set; }

        public Coordinates Coordinates { get; set; }

        public Attachment Avatar { get; set; }

        public IList<Attachment> Pictures { get; set; }

        public Attachment Audio { get; set; }
    }
}
