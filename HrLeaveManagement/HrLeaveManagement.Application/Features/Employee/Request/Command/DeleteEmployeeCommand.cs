using HrLeaveManagement.Application.Responses;
using MediatR;

namespace HrLeaveManagement.Application.Features.Employee.Request.Command
{
    public class DeleteEmployeeCommand : IRequest<BaseCommandResponse>
    {
        public int Id { get; set; }
    }
}
