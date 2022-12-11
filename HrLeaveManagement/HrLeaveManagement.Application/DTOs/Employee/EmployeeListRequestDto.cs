using HrLeaveManagement.Application.DTOs.Common;

namespace HrLeaveManagement.Application.DTOs.Employee
{
    public class EmployeeListRequestDto : BaseDto
    {
        public string EmpName { get; set; }
        public int EmpAddress { get; set; }

        public string EmpPhone { get; set; }

        public string EmpType { get; set; }
    
    }
}
