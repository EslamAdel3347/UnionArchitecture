using HrLeaveManagement.Domain.Common;
using System.Collections.Generic;

namespace HrLeaveManagement.Domain
{
    public class Department : BaseDomainEntity
    {
        public string DepName { get; set; }
        public int DepartmentAddress { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }

    }


}
