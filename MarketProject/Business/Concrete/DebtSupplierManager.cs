using MarketProject.Business.Abstract;
using MarketProject.Core.Utilities.Results;
using MarketProject.DataAccess.Abstract;
using MarketProject.DataAccess.Concrete;
using MarketProject.Entities.Concrete;
using MarketProject.Entities.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace MarketProject.Business.Concrete
{
    public class DebtSupplierManager : IDebtSupplierService
    {
        private readonly IDebtSupplierDal _debtSupplierDal = new EfDebtSupplierDal();
        private readonly ISupplierService _supplierService = new SupplierManager();
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

        public IDataResult<List<DebtSupplier>> GetListBySupplierId(int supplierId)
        {
            return new SuccessDataResult<List<DebtSupplier>>(_debtSupplierDal.GetList(x => x.SupplierId == supplierId).ToList());
        }

        public IDataResult<List<DebtSupplier>> GetList()
        {
            return new SuccessDataResult<List<DebtSupplier>>(_debtSupplierDal.GetList().ToList());
        }

        public IDataResult<List<SupplierTotalDebtDto>> GetSupplierTotalDebt()
        {
            List<Supplier> suppliers = _supplierService.GetList().Data;
            var items = suppliers.Select(x => new SupplierTotalDebtDto()
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                PhoneNumber = x.PhoneNumber,
                AmountOfDebt = _debtSupplierDal.GetList(y => y.SupplierId == x.Id).ToList().Sum(z => z.AmountOfDebt),
                AmountPaid = _debtSupplierDal.GetList(y => y.SupplierId == x.Id).ToList().Sum(z => z.AmountPaid),
                RemaingDebt = _debtSupplierDal.GetList(y => y.SupplierId == x.Id).ToList().Sum(z => z.RemaingDebt) 
            }).ToList();
            return new SuccessDataResult<List<SupplierTotalDebtDto>>(items);
        }

        public IDataResult<SupplierTotalDebtDto> GetSupplierTotalDebtBySupplierId(int supplierId)
        {
            Supplier supplier = _supplierService.GetById(supplierId).Data;
            float _debt = _debtSupplierDal.GetList(x => x.SupplierId == supplier.Id).ToList().Sum(y => y.AmountOfDebt);
            float _paid = _debtSupplierDal.GetList(x => x.SupplierId == supplier.Id).ToList().Sum(y => y.AmountPaid);
            float _remaing = _debtSupplierDal.GetList(x => x.SupplierId == supplier.Id).ToList().Sum(y => y.RemaingDebt);

            SupplierTotalDebtDto supplierTotalDebtDto = new SupplierTotalDebtDto()
            {
                Id = supplier.Id,
                FirstName = supplier.FirstName,
                LastName = supplier.LastName,
                PhoneNumber = supplier.PhoneNumber,
                AmountOfDebt = _debt,
                AmountPaid = _paid,
                RemaingDebt = _remaing,
            };
            return new SuccessDataResult<SupplierTotalDebtDto>(supplierTotalDebtDto);
        }

        public IResult Update(DebtSupplier debtSupplier)
        {
            _debtSupplierDal.Update(debtSupplier);
            return new SuccessResult();
        }

        public IDataResult<DebtSupplier> GetBySupplierId(int supplierId)
        {
            return new SuccessDataResult<DebtSupplier>(_debtSupplierDal.Get(x => x.SupplierId == supplierId));
        }
    }
}
