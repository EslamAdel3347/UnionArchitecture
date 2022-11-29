using HrLeaveManagement.Application.DTOs.Department;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrLeaveManagement.Application.Features.Department.Requests.Query
{
    public class GetDepartmentList : IRequest<List<DepartmentRequestDto>>
    {
        public string Name { get; set; }
    }
}
