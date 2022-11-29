using HrLeaveManagement.Application.DTOs.Common;

namespace HrLeaveManagement.Application.DTOs.Department
{
    public class CreateDepartmentRequestDto : BaseDto,IDepartmentRequestDto
    {
        public string DepName { get; set; }
        public int DepartmentAddress { get; set; }

    }


}
