using HrLeaveManagement.Application.Presistanse.Contracts;
using HrLeaveManagement.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HrLeaveManagement.Presistance.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly leaveManagementDbContext dbContext;

        public LeaveRequestRepository(leaveManagementDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task ChangeLeaveRequestApproval(LeaveRequest leaveRequest, bool? ApprovalStatus)
        {
            leaveRequest.Approved =(bool) ApprovalStatus;
            dbContext.Entry(leaveRequest).State = EntityState.Modified;
            await dbContext.SaveChangesAsync();
        }

        public async Task<List<LeaveRequest>> GetLeaveRequestListWithDatai()
        {

            var ListLeaveReqDet = await dbContext.LeaveRequests.Include(z => z.LeaveType).ToListAsync();
            return ListLeaveReqDet;
        }

        public async Task<LeaveRequest> GetLeaveRequestWithDatails(int Id)
        {
            var LeaveReqDet = await dbContext.LeaveRequests.Include(a=>a.LeaveType).FirstOrDefaultAsync(a => a.Id == Id);
            return LeaveReqDet;
        }
    }
}
