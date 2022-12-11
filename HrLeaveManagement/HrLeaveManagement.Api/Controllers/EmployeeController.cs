using HrLeaveManagement.Application.DTOs.Employee;
using HrLeaveManagement.Application.Features.Employee.Request.Query;
using HrLeaveManagement.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrLeaveManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            this._mediator = mediator;
        
        }


        // GET: api/<DepartmentController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeRequestDto>>> Get()
        {
            var Employee = await _mediator.Send(new GetEmployeeList {});
            return Ok(Employee);
            
        }
 
        [HttpGet("{Id}")]
        public async Task<ActionResult<EmployeeRequestDto>> Get(int Id)
        {
            var Department = await _mediator.Send(new GetEmployee { Id = Id });
            return Ok(Department);
        }


        [HttpGet]
        [Route("GetEmpAndParentName")]
        public async Task<ActionResult<Unit>> GetEmpAndParentName(int Id)
        {
            var Emp = await _mediator.Send(new GetEmployeeAndParent { Id = Id });
            return Ok(Emp);
        }

        [HttpGet]
        [Route("SearchEmployee")]
        public async Task<ActionResult<EmployeeRequestDto>> SearchEmployee(string Name)
        {
            var Department = await _mediator.Send(new GetEmployeeByName { Name = Name });
            return Ok(Department);
        }
        [HttpGet]
        [Route("GetEmployeeListByDepartment")]
        public async Task<ActionResult<IEnumerable<EmployeeRequestDto>>> GetEmpListByDep(int DepartmentID)
        {
            var Employee = await _mediator.Send(new GetEmployeeListByDepartmentId {DepartmentID= DepartmentID });
            return Ok(Employee);

        }
        [HttpGet]
        [Route("GetEmployeeByDepartment")]
        public async Task<ActionResult<EmployeeRequestDto>> GetEmpByDep(int DepartmentID)
        {
            var Employee = await _mediator.Send(new GetEmployeeByDepartmentId { DepartmentID = DepartmentID });
            return Ok(Employee);

        }




        //// POST api/<DepartmentController>
        //[HttpPost]
        //public async Task<ActionResult<DepartmentDto>> Post([FromBody] CreateDepartmentRequestDto depatment)
        //{
        //    var Command = new CreateDepartmentCommand { CreateDepartmentRequest = depatment };
        //    var response = await _mediator.Send(Command);

        //    return Ok(response);
        //}

        //// PUT api/DepartmentController>/5
        //[HttpPut("{id}")]
        //public async Task<ActionResult> Put(int Id, [FromBody] UpdateDepartmentRequestDto updateDepartment)
        //{
        //    var command = new UpdateDepartmentCommand { Id = Id, UpdateDepartmentRequest = updateDepartment };
        //    await _mediator.Send(command);

        //    return NoContent();
        //}


        //// DELETE api/<DepartmentController>/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult> Delete(int id)
        //{
        //    var Command = new DeleteDepartmentCommand { Id = id };
        //    await _mediator.Send(Command);
        //    return NoContent();
        //}
    }
}
