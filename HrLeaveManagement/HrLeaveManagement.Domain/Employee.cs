using HrLeaveManagement.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HrLeaveManagement.Domain
{
    public class Employee : BaseDomainEntity
    {
        public string EmpName { get; set; }
        public int EmpAddress { get; set; }

        public string EmpPhone { get; set; }

        
        [Required,ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        public string EmpType { get; set; }


    }


}
