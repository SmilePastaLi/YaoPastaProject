using Yao.PastaProject.Domain.Abstractions;
using Yao.PastaProject.Domain.Models;

namespace Yao.PastaProject.Domain.Repositories
{
    public interface IUserRepository : IRepository<User, string>
    {
    }
}
