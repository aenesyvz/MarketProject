using MarketProject.Business.Abstract;
using MarketProject.Core.Utilities.Results;
using MarketProject.DataAccess.Abstract;
using MarketProject.DataAccess.Concrete;
using MarketProject.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace MarketProject.Business.Concrete
{
    public class DebtSupplierManager : IDebtSupplierService
    {
        private readonly IDebtSupplierDal _debtSupplierDal = new EfDebtSupplierDal();

        public IResult Add(DebtSupplier debtSupplier)
        {
            _debtSupplierDal.Add(debtSupplier);
            return new SuccessResult();
        }

        public IResult Delete(DebtSupplier debtSupplier)
        {
            _debtSupplierDal.Delete(debtSupplier);
            return new SuccessResult();
        }

        public IDataResult<DebtSupplier> GetById(int id)
        {
            return new SuccessDataResult<DebtSupplier>(_debtSupplierDal.Get(x => x.Id == id));
        }

        public IDataResult<DebtSupplier> GetBySupplierId(int supplierId)
        {
            return new SuccessDataResult<DebtSupplier>(_debtSupplierDal.Get(x => x.SupplierId == supplierId));
        }

        public IDataResult<List<DebtSupplier>> GetList()
        {
            return new SuccessDataResult<List<DebtSupplier>>(_debtSupplierDal.GetList().ToList());
        }

        public IResult Update(DebtSupplier debtSupplier)
        {
            _debtSupplierDal.Update(debtSupplier);
            return new SuccessResult();
        }
    }
}
