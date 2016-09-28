using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sbabu.Web.Models;
using Sbabu.Web.Repository.Infrastructure;

namespace Sbabu.Web.Repository.Abstract
{
    public interface IUserRepository : IRepository<User>
    {
    }
}
