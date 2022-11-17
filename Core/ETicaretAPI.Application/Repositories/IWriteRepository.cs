using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    public interface IWriteRepository<T>:IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddRangeAsync(List<T> data);
        bool Remove(T model);
        bool RemoveRange(List<T> data);
        Task<bool> RemoveById(string Id);
        bool Update(T model);

        Task<int> SaveAsync();
    }
}
