using HrLeaveManagement.Application.DTOs.Employee;
using MediatR;

namespace HrLeaveManagement.Application.Features.Employee.Request.Command
{
    public class UpdateEmployeeCommand : IRequest<UpdateEmployeeRequestDto>
    {
        public UpdateEmployeeRequestDto UpdateEmployee { get; set; }
        public int Id { get; set; }
    }
}
