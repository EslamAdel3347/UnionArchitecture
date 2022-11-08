using HrLeaveManagement.Application.DTOs.Common;
using System;

namespace HrLeaveManagement.Application.DTOs.LeaveRequest
{
    public class UpdateLeaveRequestDto:BaseDto,ILeaveRequestDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int LeaveTypeID { get; set; }

        public bool Cancaled { get; set; }
        public string RequestComments { get; set; }


    }
}
