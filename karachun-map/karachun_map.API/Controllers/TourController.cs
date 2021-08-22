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
using karachun_map.Data.Base;
using karachun_map.BI.Interfaces;
using karachun_map.Data.Dto;
using karachun_map.Data.Filters;
using karachun_map.Data.ViewModels.Input;

namespace karachun_map.API.Controllers
{
    [ApiController]
    [Route("map/[Controller]")]
    public class TourController : BaseController
    {
        private readonly ILogger<TourController> _logger;
        private readonly IMapper _mapper;
        private readonly ITours _tours;

        public TourController(ILogger<TourController> logger, IMapper mapper, ITours tours)
        {
            _logger = logger;
            _mapper = mapper;
            _tours = tours;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll([FromQuery] TourFilter filter)
        {
            var result = await _tours.GetAll(filter);

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTour(int id)
        {
            var result = await _tours.Get(id);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromForm] TourCreate model)
        {
            var result = await _tours.CreateTour(_mapper.Map<TourInputDto>(model));

            if (!result)
                return BadRequest("Непредвиденная ошибка!");

            return Ok(result);
        }

        [HttpPost("{id}")]
        public async Task<IActionResult> Update([FromForm] TourUpdate model)
        {
            return Ok();
        }
    }
}
