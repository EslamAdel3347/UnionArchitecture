using HrLeaveManagement.Application.DTOs.Employee;
using MediatR;
using System.Collections.Generic;

namespace HrLeaveManagement.Application.Features.Employee.Request.Query
{
    public class GetEmployeeListByDepartmentId : IRequest<List<EmployeeRequestDto>>
    {
        public int DepartmentID { get; set; }
    }




}
