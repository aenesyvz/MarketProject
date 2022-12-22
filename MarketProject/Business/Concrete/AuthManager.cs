using MarketProject.Business.Abstract;
using MarketProject.Core.Utilities.Results;
using MarketProject.Entities.Concrete;
using MarketProject.Entities.Dtos;

namespace MarketProject.Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private readonly IAdminService _adminService = new AdminManager();

        public IDataResult<Admin> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _adminService.AdminToCheck(userForLoginDto);
            if (userToCheck.Success)
            {
                return new SuccessDataResult<Admin>(userToCheck.Data);
            }

            return new ErrorDataResult<Admin>("Lütfen bilgilerini kontrol ediniz!");
        }
    }
}
