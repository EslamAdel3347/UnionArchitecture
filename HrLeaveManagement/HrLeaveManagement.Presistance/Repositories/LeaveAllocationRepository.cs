using HrLeaveManagement.Application.Presistanse.Contracts;
using HrLeaveManagement.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HrLeaveManagement.Presistance.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly leaveManagementDbContext dbContext;

        public LeaveAllocationRepository(leaveManagementDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<LeaveAllocation> GetLeaveAllocationWithDetails(int Id)
        {
            var LeaveAllocationList = await dbContext.LeaveAllocations.Include(a => a.leaveType).FirstOrDefaultAsync(a=>a.Id==Id);
            return LeaveAllocationList;
        }

        public async Task<List<LeaveAllocation>> GetListLeaveAllocationWithDetails()
        {
            var LeaveAllocationList =await dbContext.LeaveAllocations.Include(a=>a.leaveType).ToListAsync();
            return LeaveAllocationList;
        }
    }
}
