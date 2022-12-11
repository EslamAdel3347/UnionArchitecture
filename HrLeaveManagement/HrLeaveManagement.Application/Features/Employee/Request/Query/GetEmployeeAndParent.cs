using HrLeaveManagement.Application.DTOs.Employee;
using MediatR;

namespace HrLeaveManagement.Application.Features.Employee.Request.Query
{
    public class GetEmployeeAndParent : IRequest<EmployeeAndParentDto>
    {
        public int Id { get; set; }
    }




}
