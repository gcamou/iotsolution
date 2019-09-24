using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoDB.GenericRepository.Controllers
{
    using Core.Abstractions.Services;
    using Core.Abstractions.Biz;
    using WebApi.Model.Response;
    using WebApi.Model.Request;
    using WebApi.Extensions;

    [Route("[controller]")]
    [ApiController]
    public class MeassureController : ControllerBase
    {
        private readonly IMeassureService _meassureService;

        public MeassureController(IMeassureService meassureService)
        {
            _meassureService = meassureService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MeassureResponse>>> Get()
        {
            var result = await _meassureService.GetAll().ToResponseAsync<MeassureBiz, MeassureResponse>();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MeassureResponse>> Get(Guid id)
        {
            var result = await _meassureService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<MeassureResponse>> Post([FromBody] MeassureRequest meassureRequest)
        {
            await _meassureService.AddAsync(meassureRequest.ToBiz<MeassureRequest, MeassureBiz>());

            var result = await _meassureService.GetByIdAsync(meassureRequest.Id);
            return Ok(result);
        }
    }
}