using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Yao.PastaProject.Infrastructure.Repositories
{
    internal static class AggregateIncludesExtensions
    {
        public static IQueryable<TEntity> AggregateIncludes<TEntity>(
            this IQueryable<TEntity> query,
            IEnumerable<Expression<Func<TEntity, object?>>> includes)
            where TEntity : class
            => includes.Aggregate(query, (queryable, include) => queryable.Include(include));
    }
}
