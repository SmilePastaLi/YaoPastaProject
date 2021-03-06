using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Yao.PastaProject.Domain.Abstractions
{
    public interface IRepository<TEntity, TKey>
       where TEntity : class
    {
        IUnitOfWork UnitOfWork { get; }
        IQueryable<TEntity> NoTrackingQueryable { get; }
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> GetAsync(TKey key);
        Task<TEntity> GetAsync(TKey key, params Expression<Func<TEntity, object>>[] includes);
    }
}
