using HrLeaveManagement.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HrLeaveManagement.Application.Presistanse.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task<LeaveAllocation> GetLeaveAllocationWithDetails(int Id);
        Task<List<LeaveAllocation>> GetListLeaveAllocationWithDetails();


    }
}
