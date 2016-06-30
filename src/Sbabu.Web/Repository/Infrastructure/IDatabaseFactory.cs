using System;

namespace Sbabu.Web.Repository.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        DatabaseContext Get();
    }
}