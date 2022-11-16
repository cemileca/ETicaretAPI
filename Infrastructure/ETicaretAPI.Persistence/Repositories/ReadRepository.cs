using ETicaretAPI.Application.Interfaces;
using ETicaretAPI.Doamin.Entities.Common;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ETicaretAPIDbContext _context;

        public ReadRepository(ETicaretAPIDbContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
            => Table;
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> metod)
            => Table.Where(metod);
        public Task<T> GetSingLeAsync(Expression<Func<T, bool>> model)
            => Table.FirstOrDefaultAsync(model);

        public Task<T> GetByIdAsync(string Id)
            => Table.FirstOrDefaultAsync(p => p.Id == Guid.Parse(Id));

    }
}
