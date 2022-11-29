
using HrLeaveManagement.Application.DTOs.Department;
using HrLeaveManagement.Application.DTOs.LeaveRequest;
using HrLeaveManagement.Application.Features.Department.Requests.Command;
using HrLeaveManagement.Application.Features.Department.Requests.Query;
using HrLeaveManagement.Application.Features.LeaveRequest.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HrLeaveManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DepartmentController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        // GET: api/<DepartmentController>
        [HttpGet("{Name}")]
        public async Task<ActionResult<IEnumerable<DepartmentDto>>> Get(string Name)
        {
            var Department = await _mediator.Send(new GetDepartmentList { Name=Name});
            return Ok(Department);
        }

        // GET api/<DepartmentController>/5
        [HttpGet]
        [Route("SearchDepartment")]
        public async Task<ActionResult<DepartmentDto>> SearchDepartment(string Name)
        {
            var LeaveRequest = await _mediator.Send(new GetDepartment { Name = Name });
            return Ok(LeaveRequest);
        }

        // POST api/<DepartmentController>
        [HttpPost]
        public async Task<ActionResult<DepartmentDto>> Post([FromBody] CreateDepartmentRequestDto depatment)
        {
            var Command = new CreateDepartmentCommand { CreateDepartmentRequest = depatment };
            var response = await _mediator.Send(Command);

            return Ok(response);
        }

        // PUT api/DepartmentController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int Id, [FromBody] UpdateDepartmentRequestDto updateDepartment)
        {
            var command = new UpdateDepartmentCommand { Id = Id, UpdateDepartmentRequest = updateDepartment };
            await _mediator.Send(command);

            return NoContent();
        }


        // DELETE api/<DepartmentController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var Command = new DeleteDepartmentCommand { Id = id };
            await _mediator.Send(Command);
            return NoContent();
        }
    }
}
