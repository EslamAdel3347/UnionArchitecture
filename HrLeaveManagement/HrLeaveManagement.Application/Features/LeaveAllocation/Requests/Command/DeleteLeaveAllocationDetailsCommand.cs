using MediatR;

namespace HrLeaveManagement.Application.Features.LeaveAllocation.Requests
{
    public class DeleteLeaveAllocationDetailsCommand : IRequest
    {
        public int Id { get; set; }
    }

}
