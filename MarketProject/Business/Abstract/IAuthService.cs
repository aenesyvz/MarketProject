using MarketProject.Core.Utilities.Results;
using MarketProject.Entities.Concrete;
using MarketProject.Entities.Dtos;

namespace MarketProject.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<Admin> Login(UserForLoginDto userForLoginDto);
    }
}
