using HrLeaveManagement.Application.DTOs.Common;

namespace HrLeaveManagement.Application.DTOs
{
    public class UpadteLeaveTypeDto:BaseDto
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
