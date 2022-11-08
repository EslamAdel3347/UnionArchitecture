using HrLeaveManagement.Application.DTOs;
using MediatR;

namespace HrLeaveManagement.Application.Features.LeaveTypes.Requests
{
    public class CreateLeaveTypeCommand : IRequest<int>
    {
        public CreateLeaveTypeDto CreateLeaveTypeDto { get; set; }
    }
}
