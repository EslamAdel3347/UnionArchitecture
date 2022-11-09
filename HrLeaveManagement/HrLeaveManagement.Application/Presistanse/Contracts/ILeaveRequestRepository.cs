using HrLeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HrLeaveManagement.Application.Presistanse.Contracts
{
    public  interface ILeaveRequestRepository:IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestWithDatails(int Id);
        Task<List<LeaveRequest>> GetLeaveRequestListWithDatai();
        Task ChangeLeaveRequestApproval(LeaveRequest leaveRequest,bool ?ApprovalStatus);
    }
}
