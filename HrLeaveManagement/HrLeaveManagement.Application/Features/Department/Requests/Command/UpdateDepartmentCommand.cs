using HrLeaveManagement.Application.DTOs.Department;
using HrLeaveManagement.Application.Responses;
using MediatR;

namespace HrLeaveManagement.Application.Features.Department.Requests.Command
{
    public class UpdateDepartmentCommand : IRequest<BaseCommandResponse>
    {
        public int Id { get; set; }
        public UpdateDepartmentRequestDto UpdateDepartmentRequest { get; set; }
    }
}
