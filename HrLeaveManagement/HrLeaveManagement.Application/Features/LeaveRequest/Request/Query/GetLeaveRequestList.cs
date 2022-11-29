using HrLeaveManagement.Application.DTOs.LeaveRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrLeaveManagement.Application.Features.LeaveRequest.Request
{
  public  class GetLeaveRequestList:IRequest<List<DepartmentDto>>
    {
    }
}
