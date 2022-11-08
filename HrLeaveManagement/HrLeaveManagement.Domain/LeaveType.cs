using HrLeaveManagement.Domain.Common;
using System;

namespace HrLeaveManagement.Domain
{
    public class LeaveType: BaseDomainEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
        
    }
}
