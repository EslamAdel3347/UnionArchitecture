using HrLeaveManagement.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrLeaveManagement.Application.Features.LeaveAllocation.Requests
{
    public class GetLeaveAllocationDetailsRequest:IRequest<LeaveAllocationDto>
    {
        public int Id { get; set; }
    }

}
