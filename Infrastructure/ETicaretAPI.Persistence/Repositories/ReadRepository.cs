using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities.Common;
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
        readonly private ETicaretAPIDbContext _context;

        public ReadRepository(ETicaretAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
            => Table.AsNoTracking();
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> model)
           => Table.Where(model);
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> model)
              => await Table.FirstOrDefaultAsync(model);
        public async Task<T> GetByIdAsync(string id)
            =>await Table.FindAsync(Guid.Parse(id));

        
    }
}
