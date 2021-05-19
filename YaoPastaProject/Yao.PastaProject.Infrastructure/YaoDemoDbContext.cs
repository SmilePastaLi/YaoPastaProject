using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using Yao.PastaProject.Domain.Abstractions;
using Yao.PastaProject.Domain.Models;

namespace Yao.PastaProject.Infrastructure
{
    public class YaoDemoDbContext : DbContext, IUnitOfWork
    {
        public YaoDemoDbContext(DbContextOptions<YaoDemoDbContext> options)
          : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            return await SaveChangesAsync(cancellationToken) > 0;
        }
    }
}
