using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karachun_map.Data.Entity
{
    public class Coordinates : Base
    {
        //Широта 
        public double Lat { get; set; }

        //Долгота
        public double Lng { get; set; }
    }
}
