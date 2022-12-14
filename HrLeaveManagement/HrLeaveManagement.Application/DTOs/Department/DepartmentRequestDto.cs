using HrLeaveManagement.Application.DTOs.Common;
using HrLeaveManagement.Application.DTOs.Employee;
using HrLeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrLeaveManagement.Application.DTOs.Department
{
    public class DepartmentRequestDto:BaseDto
    {
        public string DepName { get; set; }
        public int DepartmentAddress { get; set; }
        public virtual ICollection<EmployeeListRequestDto> Employees { get; set; }
    }


}
