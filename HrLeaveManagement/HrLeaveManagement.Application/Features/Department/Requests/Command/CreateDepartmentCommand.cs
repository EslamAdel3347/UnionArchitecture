using HrLeaveManagement.Application.DTOs.Department;
using HrLeaveManagement.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrLeaveManagement.Application.Features.Department.Requests.Command
{
    public class CreateDepartmentCommand:IRequest<BaseCommandResponse>
    {
        public CreateDepartmentRequestDto CreateDepartmentRequest { get; set; }
    }
}
