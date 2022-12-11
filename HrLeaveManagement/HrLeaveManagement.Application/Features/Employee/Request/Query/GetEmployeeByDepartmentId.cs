using HrLeaveManagement.Application.DTOs.Employee;
using MediatR;

namespace HrLeaveManagement.Application.Features.Employee.Request.Query
{
    public class GetEmployeeByDepartmentId : IRequest<EmployeeRequestDto>
    {
        public int DepartmentID { get; set; }
    }




}
