using HrLeaveManagement.Application.DTOs;
using MediatR;
using System.Collections.Generic;

namespace HrLeaveManagement.Application.Features.LeaveAllocation.Requests
{
    public class GetLeaveAllocationListRequest : IRequest<List<LeaveAllocationDto>>
    {
        
    }
}
