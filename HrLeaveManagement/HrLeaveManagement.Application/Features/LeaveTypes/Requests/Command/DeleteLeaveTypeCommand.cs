using MediatR;

namespace HrLeaveManagement.Application.Features.LeaveTypes.Requests.Command
{
    public class DeleteLeaveTypeCommand : IRequest
    {
        public int Id { get; set; }
    }
}
