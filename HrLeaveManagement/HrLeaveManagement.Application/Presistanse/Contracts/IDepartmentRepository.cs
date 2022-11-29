using HrLeaveManagement.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HrLeaveManagement.Application.Presistanse.Contracts
{
    public interface IDepartmentRepository : IGenericRepository<Department>
    {
        Task<Department> GetDepartmentByName(string Name);
        Task<List<Department>> GetListDepartmentAndEmpByName(string Name);
    }

}
