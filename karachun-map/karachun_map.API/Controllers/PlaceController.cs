﻿using AutoMapper;
using AutoMapper.Collection;
using AutoMapper.EntityFrameworkCore;
using karachun_map.API.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using karachun_map.Data.Base;
using karachun_map.BI.Interfaces;

namespace karachun_map.API.Controllers
{
    [ApiController]
    [Route("map/[Controller]")]
    public class PlaceController : BaseController
    {
        private readonly ILogger<PlaceController> _logger;
        private readonly IMapper _mapper;
        private readonly IPlaces _place;

        public PlaceController(ILogger<PlaceController> logger, IMapper mapper, IPlaces place)
        {
            _logger = logger;
            _mapper = mapper;
            _place = place;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll([FromQuery] Filter filter)
        {
            return Ok();
        }

        [HttpGet("all/full-data")]
        public async Task<IActionResult> GetFullData([FromQuery] Filter filter)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPlace(int id)
        {
            return Ok();
        }
    }
}
