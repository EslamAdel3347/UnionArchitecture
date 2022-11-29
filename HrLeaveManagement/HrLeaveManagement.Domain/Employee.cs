using HrLeaveManagement.Domain.Common;

namespace HrLeaveManagement.Domain
{
    public class Employee : BaseDomainEntity
    {
        public string EmpName { get; set; }
        public int EmpAddress { get; set; }

        public string EmpPhone { get; set; }

        

        public virtual Department Department { get; set; }

    }


}
