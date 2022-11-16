using ETicaretAPI.Doamin.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Interfaces
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> model);
        Task<T> GetSingLeAsync(Expression<Func<T, bool>> model);
        Task<T> GetByIdAsync(string Id);

    }
}
