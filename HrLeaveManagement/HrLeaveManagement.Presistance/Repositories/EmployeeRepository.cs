using HrLeaveManagement.Application.Presistanse.Contracts;
using HrLeaveManagement.Domain;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace HrLeaveManagement.Presistance.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        private readonly leaveManagementDbContext dbContext;

        public EmployeeRepository(leaveManagementDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }



        public async Task<Employee> GetEmployeeByName(string Name)
        {
            var emp = await dbContext.Employees.FirstOrDefaultAsync(a => a.EmpName == Name);
            return emp;
        }





     
    }

}
