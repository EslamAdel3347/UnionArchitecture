using HrLeaveManagement.Application.DTOs;
using MediatR;

namespace HrLeaveManagement.Application.Features.LeaveAllocation.Requests
{
    public class UpdateLeaveAllocationDetailsCommand : IRequest<Unit>
    {
        public UpdateLeaveAllocationDto UpdateLeaveAllocationDto { get; set; }
    }

}
