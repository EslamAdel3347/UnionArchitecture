using HrLeaveManagement.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrLeaveManagement.Application.DTOs
{
    public class LeaveAllocationDto:BaseDto,ILeaveAllocationDto
    {
        public int NumberOfDays { get; set; }


        public LeaveTypeDto leaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
