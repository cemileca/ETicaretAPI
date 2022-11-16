using ETicaretAPI.Doamin.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Interfaces
{
    public interface IWriteRepository<T>:IRepository<T> where T:BaseEntity
    {
        Task<bool> AddSync(T model);
        Task<bool> AddRangeAsync(List<T> data);
        bool Remove(T model);
        Task<bool> RemoveByIdAsync(string id);
        bool RemoveRange(T model);
        bool Update(T model);
        Task<int> SaveChangce();
    }
}
