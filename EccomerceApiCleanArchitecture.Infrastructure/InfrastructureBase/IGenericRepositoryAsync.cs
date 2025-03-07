using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccomerceApiCleanArchitecture.Infrastructure.InfrastructureBase
{
    public interface  IGenericRepositoryAsync<T> where T : class
    {
        Task<T> AddAsync(T entity);
        Task<ICollection<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> UpdateAsync(T entity);
        Task <bool> Delete(T entity);
        Task SaveChangesAsync();
        void Commit();
        void Rollback();

        Task UpdateRangeAsync(ICollection<T> entities); 

        Task  DeleteRangeAsync(ICollection<T> entities);

        IDbContextTransaction BeginTransaction();

        IDbContextTransaction EndTransaction();

        IQueryable<T> GetAsNoTracking();
        Task<IList<T>> GetAsTracking();






    }
}
