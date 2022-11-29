using HrLeaveManagement.Application.Responses;
using MediatR;

namespace HrLeaveManagement.Application.Features.Department.Requests.Command
{
    public class DeleteDepartmentCommand : IRequest<BaseCommandResponse>
    {
        public int Id { get; set; }
    }
}
