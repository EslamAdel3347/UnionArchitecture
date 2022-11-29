using HrLeaveManagement.Application.Presistanse.Contracts;
using HrLeaveManagement.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace HrLeaveManagement.Presistance.Repositories
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        private readonly leaveManagementDbContext dbContext;

        public DepartmentRepository(leaveManagementDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

      

        public async Task<Department> GetDepartmentByName(string Name)
        {
                var Department = await dbContext.Departments.Include(a => a.Employees).FirstOrDefaultAsync(a => a.DepName == Name);
            return Department;
        }

        

      

        public async Task<List<Department>> GetListDepartmentAndEmpByName(string Name)
        {
            var DepList = await dbContext.Departments.Where(a=>a.DepName==Name).Include(a=>a.Employees).ToListAsync();

            
         
            return DepList;
        }
    }

}
