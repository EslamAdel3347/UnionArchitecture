using HrLeaveManagement.Application.DTOs.Department;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrLeaveManagement.Application.Features.Department.Requests.Query
{
    public class GetDepartment : IRequest<DepartmentRequestDto>
    {
        public string Name { get; set; }
    }
}
