using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using karachun_map.Data.Base;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace karachun_map.Data.ViewModels.Input
{
    public class TourUpdate
    {
        public string Name { get; set; }

        public string Description { get; set; }

        [MinLength(2, ErrorMessage = "Маршрут должен содержать минимум две точки!")]
        public Coordinates[] CoordinatesPlaces { get; set; }

        public IFormFile Avatar { get; set; }

        public IFormFileCollection Pictures { get; set; }
    }
}
