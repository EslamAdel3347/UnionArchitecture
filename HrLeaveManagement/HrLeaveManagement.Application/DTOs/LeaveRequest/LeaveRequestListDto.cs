using HrLeaveManagement.Application.DTOs.Common;
using System;

namespace HrLeaveManagement.Application.DTOs.LeaveRequest
{
    public class LeaveRequestListDto : BaseDto
    {
     
        public LeaveTypeDto LeaveType { get; set; }
   
        public DateTime DataRequest { get; set; }

  

        public bool Approved { get; set; }
 
    }
}
