using HrLeaveManagement.Application.DTOs.LeaveRequest;
using MediatR;

namespace HrLeaveManagement.Application.Features.LeaveRequest.Request
{
    public class UpdateLeaveRequestCommand : IRequest<Unit>
    {
        public int ID { get; set; }
        public UpdateLeaveRequestDto UpdateLeaveRequestDto { get; set; }
        public ChangeLeaveRequestApprovalDto ChangeLeaveRequestApprovalDto { get; set; }
    }
}
