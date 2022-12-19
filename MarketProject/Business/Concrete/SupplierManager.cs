using MarketProject.Business.Abstract;
using MarketProject.Core.Utilities.Results;
using MarketProject.DataAccess.Abstract;
using MarketProject.DataAccess.Concrete;
using MarketProject.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace MarketProject.Business.Concrete
{
    public class SupplierManager : ISupplierService
    {
        private readonly ISupplierDal _supplierDal = new EFSupplierDal();
        public IResult Add(Supplier supplier)
        {
            _supplierDal.Add(supplier);
            return new SuccessResult();
        }

        public IResult Delete(Supplier supplier)
        {
            _supplierDal.Delete(supplier);
            return new SuccessResult();
        }

        public IDataResult<Supplier> GetById(int id)
        {
            return new SuccessDataResult<Supplier>(_supplierDal.Get(x => x.Id == id));
        }

        public IDataResult<List<Supplier>> GetList()
        {
            return new SuccessDataResult<List<Supplier>>(_supplierDal.GetList().ToList());
        }

        public IResult Update(Supplier supplier)
        {
            _supplierDal.Update(supplier);
            return new SuccessResult();
        }
    }
}
