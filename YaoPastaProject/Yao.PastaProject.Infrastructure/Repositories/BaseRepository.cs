using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Yao.PastaProject.Domain.Abstractions;

namespace Yao.PastaProject.Infrastructure.Repositories
{
    public abstract class BaseRepository<TContext, TEntity, TKey> : IRepository<TEntity, TKey>
        where TContext : DbContext, IUnitOfWork
        where TEntity : EntityBase
        where TKey : IComparable<TKey>
    {
        public IUnitOfWork UnitOfWork => Context;
        public IQueryable<TEntity> NoTrackingQueryable => Context.Set<TEntity>().AsNoTracking();

        protected TContext Context { get; }

        protected BaseRepository(TContext context)
        {
            Context = context;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            Context.Add(entity);
            await Context.SaveEntitiesAsync();
            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            await Context.SaveEntitiesAsync();
            return entity;
        }

        public async Task<TEntity> GetAsync(TKey key)
        {
            return await Context.Set<TEntity>().FirstOrDefaultAsync(e => e.Id.Equals(key));
        }

        public async Task<TEntity> GetAsync(TKey key, params Expression<Func<TEntity, object>>[] includes)
        {
            return await Context.Set<TEntity>().AggregateIncludes(includes).FirstOrDefaultAsync(e => e.Id.Equals(key));
        }
    }
}
