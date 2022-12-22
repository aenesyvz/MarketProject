using MarketProject.Business.Abstract;
using MarketProject.Core.Utilities.Results;
using MarketProject.DataAccess.Abstract;
using MarketProject.DataAccess.Concrete;
using MarketProject.Entities.Concrete;
using MarketProject.Entities.Dtos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketProject.Business.Concrete
{
    public class AdminManager : IAdminService
    {
        private readonly IAdminDal _managerDal = new EfAdminDal();
        public IResult Add(Admin manager)
        {
            _managerDal.Add(manager);
            return new SuccessResult();
        }

        public IDataResult<Admin> AdminToCheck(UserForLoginDto userForLoginDto)
        {
            var response = _managerDal.Get(x => x.UserName == userForLoginDto.UserName && x.Password == userForLoginDto.Password);
            if(response == null)
            {
                return new ErrorDataResult<Admin>("Kullanıcı bulunamadı");
            }
            
            return new SuccessDataResult<Admin>(response);
        }

        public IResult Delete(Admin manager)
        {
            _managerDal.Delete(manager);
            return new SuccessResult();
        }

        public IDataResult<Admin> GetById(int id)
        {
            return new SuccessDataResult<Admin>(_managerDal.Get(x => x.Id == id));
        }

        public IDataResult<List<Admin>> GetList()
        {
            return new SuccessDataResult<List<Admin>>(_managerDal.GetList().ToList());
        }

        public IResult Update(Admin manager)
        {
            _managerDal.Update(manager);
            return new SuccessResult();
        }
    }
}
