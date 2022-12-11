using HrLeaveManagement.Application.DTOs.Common;
using HrLeaveManagement.Application.DTOs.Department;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrLeaveManagement.Application.DTOs.Employee
{
    public class EmployeeRequestDto:BaseDto
    {
        public string EmpName { get; set; }
        public int EmpAddress { get; set; }

        public string EmpPhone { get; set; }

        public string EmpType { get; set; }
        public int DepartmentId { get; set; }
        //public string DepartmentName { get; set; }
        public virtual DepartmentRequestDto DepartmentDto { get; set; }
    }

}
