using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HIMS_Application.BaseContracts
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> GetAll(bool trackChanges);
        IQueryable<T> GetByCondition(Expression<Func<T, bool>> condition, bool trackChange);
        IQueryable<T> Include(params Expression<Func<T, object>>[] includes);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
