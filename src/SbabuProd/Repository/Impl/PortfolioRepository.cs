using Sbabu.Web.Models;
using Sbabu.Web.Repository.Abstract;
using Sbabu.Web.Repository.Infrastructure;

namespace Sbabu.Web.Repository.Impl
{
    public class PortfolioRepository : RepositoryBase<Portfolio>, IPortfolioRepository
    {
        public PortfolioRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }

       
    }
}
