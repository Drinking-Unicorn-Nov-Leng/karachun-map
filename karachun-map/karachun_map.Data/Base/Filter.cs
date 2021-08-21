using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karachun_map.Data.Base
{
    public class Filter
    {
        public int Take { get; set; }

        public int Skip { get; set; }

        public string OrderBy { get; set; }
        
        public bool Descending { get; set; }
    }
}
