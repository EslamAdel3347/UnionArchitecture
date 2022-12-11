using HrLeaveManagement.Application.DTOs.Employee;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrLeaveManagement.Application.Features.Employee.Request.Command
{
    public class CreateEmployeeCommand:IRequest<Unit>
    {
        public CreateEmployeeRequestDto CreateEmployeeRequest { get; set; }
    }
}
