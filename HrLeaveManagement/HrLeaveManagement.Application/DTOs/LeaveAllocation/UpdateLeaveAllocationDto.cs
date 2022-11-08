using HrLeaveManagement.Application.DTOs.Common;

namespace HrLeaveManagement.Application.DTOs
{
    public class UpdateLeaveAllocationDto:BaseDto,ILeaveAllocationDto
    {
        public int NumberOfDays { get; set; }


        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
