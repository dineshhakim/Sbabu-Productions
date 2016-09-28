using Sbabu.Web.Models;
using Sbabu.Web.Repository.Abstract;
using Sbabu.Web.Repository.Infrastructure;

namespace Sbabu.Web.Repository.Impl
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
