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
    public class EventLogController : ControllerBase
    {
        private readonly IEventLogService _eventLogService;

        public EventLogController(IEventLogService eventLogService)
        {
            _eventLogService = eventLogService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventLogResponse>>> Get()
        {
            var result = await _eventLogService.GetAll().ToResponseAsync<EventLogBiz, EventLogResponse>();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EventLogResponse>> Get(string id)
        {
            var result = await _eventLogService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<EventLogResponse>> Post([FromBody] EventLogRequest eventLogRequest)
        {
            await _eventLogService.AddAsync(eventLogRequest.ToBiz<EventLogRequest, EventLogBiz>());

            var result = await _eventLogService.GetByIdAsync(eventLogRequest.CodeId);
            return Ok(result);
        }
    }
}