using HrLeaveManagement.Application.DTOs;
using MediatR;

namespace HrLeaveManagement.Application.Features.LeaveAllocation.Requests
{
    public class CreateLeaveAllocationDetailsCommand : IRequest<int>
    {
        public CreateLeaveAllocationDto CreateLeaveAllocationDto { get; set; }
    }

}
