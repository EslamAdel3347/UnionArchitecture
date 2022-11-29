using HrLeaveManagement.Application.DTOs.Common;
using System;

namespace HrLeaveManagement.Application.DTOs.LeaveRequest
{
    public class DepartmentDto : BaseDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeID { get; set; }
        public DateTime DataRequest { get; set; }

        public DateTime DataActioned { get; set; }
        public string RequestComments { get; set; }

        public bool Approved { get; set; }
        public bool Cancaled { get; set; }
    }
}
