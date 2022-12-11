using HrLeaveManagement.Application.Presistanse.Contracts;
using HrLeaveManagement.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<Employee> GetEmployeeAndBarentDep(int Id)
        {
            var emp = await dbContext.Employees.Where(a => a.Id == Id).Include(a => a.Department).FirstOrDefaultAsync();
            return emp;
        }

        public async Task<Employee> GetEmployeeByDepartmentID(int DepartmentId)
        {
            var EmpList = await dbContext.Employees.Where(a => a.DepartmentId == DepartmentId).FirstOrDefaultAsync();
            return EmpList;
        }

        public async Task<Employee> GetEmployeeByName(string Name)
        {
            var emp = await dbContext.Employees.FirstOrDefaultAsync(a => a.EmpName == Name);
            return emp;
        }

        public async Task<List<Employee>> GetEmployeeListByDepartmentID(int DepartmentId)
        {
            var EmpList = await dbContext.Employees.Where(a=>a.Department.Id== DepartmentId).ToListAsync();
 
        
            return EmpList;
        }


    }

}
