using HrLeaveManagement.Application.DTOs.Employee;
using MediatR;

namespace HrLeaveManagement.Application.Features.Employee.Request.Query
{
    public class GetEmployeeByName : IRequest<EmployeeRequestDto>
    {
        public string Name { get; set; }
    }




}
