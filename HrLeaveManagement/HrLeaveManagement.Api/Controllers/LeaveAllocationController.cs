using HrLeaveManagement.Application.DTOs;
using HrLeaveManagement.Application.Features.LeaveAllocation.Requests;
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
    public class LeaveAllocationController : ControllerBase
    {
        private readonly IMediator _medaitor;

        public LeaveAllocationController(IMediator medaitor)
        {
            this._medaitor = medaitor;
        }

        // GET: api/<LeaveAllocationController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LeaveAllocationDto>>> Get()
        {
            var LeaveAllocation = await _medaitor.Send(new GetLeaveAllocationDetailsRequest());
          

            return Ok(LeaveAllocation);
        }

        // GET api/<LeaveAllocationController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LeaveAllocationDto>> Get(int id)
        {
            var LeaveAllocation = await _medaitor.Send(new GetLeaveAllocationDetailsRequest { Id = id });
            return Ok(LeaveAllocation);
        }

        // POST api/<LeaveAllocationController>
        [HttpPost]
        public async Task<ActionResult<LeaveAllocationDto>> Post([FromBody] CreateLeaveAllocationDto leave)
        {
            var Command = new CreateLeaveAllocationDetailsCommand { CreateLeaveAllocationDto = leave };

            var response = await _medaitor.Send(Command);

            return Ok(response);

        }

        // PUT api/<LeaveAllocationController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateLeaveAllocationDto leaveAllocationDto)
        {

            var Command = new UpdateLeaveAllocationDetailsCommand { UpdateLeaveAllocationDto = leaveAllocationDto };
            await _medaitor.Send(Command);


            return NoContent();
        }

        // DELETE api/<LeaveAllocationController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {

            var Command = new DeleteLeaveAllocationDetailsCommand { Id = id };
            await _medaitor.Send(Command);


            return NoContent();
        }
    }
}
