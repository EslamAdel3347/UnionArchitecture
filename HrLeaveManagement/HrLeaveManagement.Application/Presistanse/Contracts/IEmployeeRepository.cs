using HrLeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HrLeaveManagement.Application.Presistanse.Contracts
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        Task<List<Employee>> GetEmployeeListByDepartmentID(int DepartmentId);
        Task<Employee> GetEmployeeByDepartmentID(int DepartmentId);
        Task<Employee> GetEmployeeByName(string Name);

        Task<Employee> GetEmployeeAndBarentDep(int Id);

    }

}
