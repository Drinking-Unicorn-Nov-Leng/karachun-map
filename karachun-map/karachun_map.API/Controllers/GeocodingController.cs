using AutoMapper;
using AutoMapper.Collection;
using AutoMapper.EntityFrameworkCore;
using karachun_map.API.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using karachun_map.Data.ViewModels.Input;
using karachun_map.BI.Interfaces;
using karachun_map.Data.Dto;
using karachun_map.Data.Base;

namespace karachun_map.API.Controllers
{
    [ApiController]
    [Route("map/[Controller]")]
    public class GeocodingController : BaseController
    {
        private readonly ILogger<AdminController> _logger;
        private readonly IMapper _mapper;
        private readonly IGeocoding _cords;

        public GeocodingController(ILogger<AdminController> logger, IMapper mapper, IGeocoding cords)
        {
            _logger = logger;
            _mapper = mapper;
            _cords = cords;
        }

        [HttpGet("objects-nearby")]
        public async Task<IActionResult> GetObjectsNearby([FromQuery] Coordinates coordinates)
        {
            var result = await _cords.GetObjectsNearby(coordinates);

            return Ok(result);
        }
    }
}
