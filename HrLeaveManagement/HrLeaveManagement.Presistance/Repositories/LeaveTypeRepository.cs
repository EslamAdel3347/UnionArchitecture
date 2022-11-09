using HrLeaveManagement.Application.Presistanse.Contracts;
using HrLeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrLeaveManagement.Presistance.Repositories
{
    public class LeaveTypeRepository:GenericRepository<LeaveType>,ILeaveTypeRepository
    {
        private readonly leaveManagementDbContext dbContext;

        public LeaveTypeRepository(leaveManagementDbContext dbContext):base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
