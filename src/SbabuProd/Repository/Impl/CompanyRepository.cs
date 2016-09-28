using Sbabu.Web.Models;
using Sbabu.Web.Repository.Abstract;
using Sbabu.Web.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sbabu.Web.Repository.Impl
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }


    }
}
