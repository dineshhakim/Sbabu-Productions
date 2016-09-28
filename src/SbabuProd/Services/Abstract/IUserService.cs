using Sbabu.Web.Models;

namespace Sbabu.Web.Services.Abstract
{
    public interface IUserService : IServiceCommand<User>
    {
        bool CheckLogin(User user);
    }
}