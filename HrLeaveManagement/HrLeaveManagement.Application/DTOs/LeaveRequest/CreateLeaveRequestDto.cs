using System;

namespace HrLeaveManagement.Application.DTOs.LeaveRequest
{
    public class CreateLeaveRequestDto:ILeaveRequestDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int LeaveTypeID { get; set; }
        public DateTime DataRequest { get; set; }

        public string RequestComments { get; set; }


    }
}