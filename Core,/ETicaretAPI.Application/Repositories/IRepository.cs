using ETicaretAPI.Doamin.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Interfaces
{
    public interface IRepository<T> where  T : BaseEntity
    {
        public DbSet<T> Table { get; }
    }
}
