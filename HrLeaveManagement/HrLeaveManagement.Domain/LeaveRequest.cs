using HrLeaveManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrLeaveManagement.Domain
{
   public class LeaveRequest: BaseDomainEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeID { get; set; }
        public DateTime DataRequest { get; set; }

        public DateTime DataActioned{ get; set; }
        public string RequestComments { get; set; }
       
        public bool Approved { get; set; }
        public bool Cancaled { get; set; }
    }
}
