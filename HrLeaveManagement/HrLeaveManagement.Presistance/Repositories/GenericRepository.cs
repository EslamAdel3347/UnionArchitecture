using HrLeaveManagement.Application.Presistanse.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HrLeaveManagement.Presistance.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly leaveManagementDbContext dbContext;

        public GenericRepository(leaveManagementDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public async Task<T> Add(T entity)
        {
            await dbContext.AddAsync(entity);
            await dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Delete(T entity)
        {
             dbContext.Set<T>().Remove(entity);
            await dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> Exits(int Id)
        {
            var entity = await Get(Id);
            return entity != null;
        }

        public async Task<T> Get(int Id)
        {
            return await dbContext.Set<T>().FindAsync(Id);
           
        }

        public async Task<IReadOnlyList<T>> GetAll()
        {
            return await dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> Update(T entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
            await dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
