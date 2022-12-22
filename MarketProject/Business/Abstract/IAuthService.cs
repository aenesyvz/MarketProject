using MarketProject.Core.Utilities.Results;
using MarketProject.Entities.Concrete;

namespace MarketProject.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<Admin> Login(Admin admin);
    }
}
