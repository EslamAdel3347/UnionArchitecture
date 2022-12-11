using HrLeaveManagement.Application.DTOs.Employee;
using MediatR;
using System;
using System.Text;

namespace HrLeaveManagement.Application.Features.Employee.Request.Query
{
    public class GetEmployee:IRequest<EmployeeRequestDto>
    {
        public int Id { get; set; }
    }




}
