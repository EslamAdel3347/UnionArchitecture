using HrLeaveManagement.Application.DTOs;
using HrLeaveManagement.Application.Features.LeaveTypes.Requests;
using HrLeaveManagement.Application.Features.LeaveTypes.Requests.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HrLeaveManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveTypesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LeaveTypesController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        // GET: api/<LeaveTypesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LeaveTypeDto>>> Get()
        {
            var LeaveTypes = await _mediator.Send(new GetLeaveTypeListRequest());

            return Ok(LeaveTypes);
        }

        // GET api/<LeaveTypesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LeaveTypeDto>> Get(int id)
        {
            var LeaveType = await _mediator.Send(new GetLeaveTypeRequest{Id = id});
            return Ok(LeaveType);
        }

        // POST api/<LeaveTypesController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateLeaveTypeDto CreateleaveTypeDto)
        {
            var command = new CreateLeaveTypeCommand { CreateLeaveTypeDto = CreateleaveTypeDto };
            var Response =await  _mediator.Send(command);
            return Ok(Response);
        }

        // PUT api/<LeaveTypesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put([FromBody] LeaveTypeDto leaveType)
        {

            var command = new UpdateLeaveTypeCommand { LeaveTypeDto = leaveType };
            await _mediator.Send(command);
            return NoContent();

        }

        // DELETE api/<LeaveTypesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteLeaveTypeCommand { Id = id };
           await _mediator.Send(command);
            return NoContent();
        }
    }
}
