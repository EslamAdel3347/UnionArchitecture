using HrLeaveManagement.Application.DTOs.Common;

namespace HrLeaveManagement.Application.DTOs
{
    public class LeaveTypeDto : BaseDto, ILeaveTypeDto
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }

}
