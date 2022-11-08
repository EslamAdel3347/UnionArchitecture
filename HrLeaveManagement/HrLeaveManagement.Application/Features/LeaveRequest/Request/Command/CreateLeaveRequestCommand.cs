using HrLeaveManagement.Application.DTOs.LeaveRequest;
using HrLeaveManagement.Application.Responses;
using MediatR;

namespace HrLeaveManagement.Application.Features.LeaveRequest.Request
{
    public class CreateLeaveRequestCommand : IRequest<BaseCommandResponse>
    {
        public CreateLeaveRequestDto CreateLeaveRequestDto { get; set; }
    }
}
