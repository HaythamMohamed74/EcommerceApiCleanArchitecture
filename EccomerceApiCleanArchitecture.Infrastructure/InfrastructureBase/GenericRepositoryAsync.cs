using EccomerceApiCleanArchitecture.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccomerceApiCleanArchitecture.Infrastructure.InfrastructureBase
{
    public class GenericRepositoryAsync<T> : IGenericRepositoryAsync<T>
        where T : class
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public GenericRepositoryAsync(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
      
        public async Task<T> AddAsync(T entity)
        {
            var result = await _applicationDbContext.Set<T>().AddAsync(entity);
             await SaveChangesAsync();
            return entity;

        }

        public IDbContextTransaction BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(T entity)
        {
            
           var result=  _applicationDbContext.Set<T>().Remove(entity);
            await SaveChangesAsync();
            return true;

        }

        public async Task DeleteRangeAsync(ICollection<T> entities)
        {

            foreach (var entity in entities)
            {
                _applicationDbContext.Entry(entity).State = EntityState.Deleted;
            }
            await SaveChangesAsync();
            
        }

        public IDbContextTransaction EndTransaction()
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<T>> GetAllAsync()
        {
            var result =await _applicationDbContext.Set<T>().ToListAsync();
            return result;
        }

        public IQueryable<T> GetAsNoTracking()
        {

            return  _applicationDbContext.Set<T>().AsNoTracking().AsQueryable();
        }

        public async Task<IList<T>> GetAsTracking()
        {
            return await _applicationDbContext.Set<T>().AsNoTracking().ToListAsync();
        }


        public async Task<T> GetByIdAsync(int id)
        {
            var result =await _applicationDbContext.Set<T>().FindAsync(id);
            return  result;
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }

        public  Task SaveChangesAsync()
        {
            return  _applicationDbContext.SaveChangesAsync();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            var result = _applicationDbContext.Set<T>().Update(entity);
           await SaveChangesAsync();
            return entity;
        }

     

        public async Task UpdateRangeAsync(ICollection<T> entities)
        {
            _applicationDbContext.Set<T>().UpdateRange(entities);
            await  SaveChangesAsync();
            

        }

        
    }
}
