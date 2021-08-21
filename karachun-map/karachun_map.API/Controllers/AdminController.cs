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

namespace karachun_map.API.Controllers
{
    [ApiController]
    [Route("map/[Controller]")]
    public class AdminController : BaseController
    {
        private readonly ILogger<AdminController> _logger;
        private readonly IMapper _mapper;
        private readonly IAdmin _admin;

        public AdminController(ILogger<AdminController> logger, IMapper mapper, IAdmin admin)
        {
            _logger = logger;
            _mapper = mapper;
            _admin = admin;
        }

        [HttpPost("add-place")]
        public async Task<IActionResult> AddPlace([FromForm] PlaceCreate model)
        {
            var result = await _admin.CreatePlace(_mapper.Map<PlaceInputDto>(model));

            if (!result)
                return BadRequest("Непредвиденная ошибка!");

            return Ok(result);
        }

        [HttpPost("update-place")]
        public async Task<IActionResult> UpdatePlace([FromForm] PlaceCreate model)
        {
            var result = await _admin.UpdatePlace(_mapper.Map<PlaceInputDto>(model));

            if (!result)
                return BadRequest("Непредвиденная ошибка!");

            return Ok(result);
        }
    }
}
