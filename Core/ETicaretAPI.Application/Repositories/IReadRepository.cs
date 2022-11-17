﻿using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    public interface IReadRepository<T>:IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWere(Expression<Func<T, bool>> model);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> model);
        Task<T>GetByIdAssync(string id);


    }
}