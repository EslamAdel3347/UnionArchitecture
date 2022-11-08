using HrLeaveManagement.Application.DTOs;
using MediatR;

namespace HrLeaveManagement.Application.Features.LeaveTypes.Requests
{
    public class GetLeaveTypeRequest : IRequest<LeaveTypeDto>
    {
        public int Id { get; set; }
    }
}
