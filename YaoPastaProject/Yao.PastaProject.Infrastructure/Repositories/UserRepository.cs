using Yao.PastaProject.Domain.Models;
using Yao.PastaProject.Domain.Repositories;

namespace Yao.PastaProject.Infrastructure.Repositories
{
    public class UserRepository: BaseRepository<YaoDemoDbContext, User, string>, IUserRepository
    {
        public UserRepository(YaoDemoDbContext context)
           : base(context)
        {
        }
    }
}
