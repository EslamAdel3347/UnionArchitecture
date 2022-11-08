using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HrLeaveManagement.Application.Presistanse.Contracts
{
   public interface IGenericRepository<T> where T:class
    {
        Task<T> Get(int Id);
        Task<IReadOnlyList<T>> GetAll();
        Task<bool> Exits(int Id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(T entity);
    }
}
