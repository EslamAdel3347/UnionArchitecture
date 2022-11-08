using MediatR;

namespace HrLeaveManagement.Application.Features.LeaveRequest.Request
{
    public class DeleteLeaveRequestCommand : IRequest
    {
        public int ID { get; set; }
       
    }
}
