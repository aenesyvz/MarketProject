using MarketProject.Business.Abstract;
using MarketProject.Core.Utilities.Results;
using MarketProject.DataAccess.Abstract;
using MarketProject.DataAccess.Concrete;
using MarketProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
