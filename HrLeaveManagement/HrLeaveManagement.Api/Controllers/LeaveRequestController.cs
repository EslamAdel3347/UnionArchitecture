
using HrLeaveManagement.Application.DTOs.LeaveRequest;
using HrLeaveManagement.Application.Features.LeaveRequest.Request;
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
    public class LeaveRequestController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LeaveRequestController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        // GET: api/<LeaveRequestController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LeaveRequestDto>>>  Get()
        {
            var LeaveRequest =await _mediator.Send(new GetLeaveRequestList());
            return Ok(LeaveRequest);
        }

        // GET api/<LeaveRequestController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var LeaveRequest =await _mediator.Send(new GetLeaveRequest { Id = id });
            return Ok(LeaveRequest);
        }

        // POST api/<LeaveRequestController>
        [HttpPost]
        public async Task<ActionResult<LeaveRequestDto>> Post([FromBody]  CreateLeaveRequestDto leave)
        {
            var Command = new CreateLeaveRequestCommand { CreateLeaveRequestDto = leave };
            var response = await _mediator.Send(Command);

            return Ok(response);
        }

        // PUT api/<LeaveRequestController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int Id ,[FromBody] UpdateLeaveRequestDto updateLeave)
        {
            var command = new UpdateLeaveRequestCommand { ID = Id, UpdateLeaveRequestDto = updateLeave };
            await _mediator.Send(command);

            return NoContent();
        }

        // PUT api/<LeaveRequestController>/5
        [HttpPut("ChangeApproval/{id}")]
        public async Task<ActionResult> ChangeApproval(int Id, [FromBody] ChangeLeaveRequestApprovalDto change)
        {
            var command = new UpdateLeaveRequestCommand { ID = Id, ChangeLeaveRequestApprovalDto = change };
            await _mediator.Send(command);

            return NoContent();
        }

        // DELETE api/<LeaveRequestController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var Command = new DeleteLeaveRequestCommand { ID = id };
           await _mediator.Send(Command);
            return NoContent();
        }
    }
}
