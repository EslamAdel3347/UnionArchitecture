using HrLeaveManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrLeaveManagement.Domain
{
   public class LeaveAllocation: BaseDomainEntity
    {

        public int NumberOfDays { get; set; }
        

        public LeaveType leaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int  Period { get; set; }

    }
}
