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
        Task<bool> AddAsync(T model);
        Task<bool> AddRangeAsync(HashSet<T> datas);
        bool Update(T model);
        Task<bool> UpdateByIdAsync(string id);
        bool UpdateRange(HashSet<T> datas);
        bool Remove(T model);
        Task<bool> RemoveByIdAsync(string id);
        bool RemoveRange(HashSet<T> datas);
        Task<int> SaveChangesAsync();
    }
}
