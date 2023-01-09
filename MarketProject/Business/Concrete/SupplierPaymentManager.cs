using MarketProject.Business.Abstract;
using MarketProject.Core.Utilities.Business;
using MarketProject.Core.Utilities.Results;
using MarketProject.DataAccess.Abstract;
using MarketProject.DataAccess.Concrete;
using MarketProject.Entities.Concrete;
using MarketProject.Entities.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace MarketProject.Business.Concrete
{
    public class SupplierPaymentManager : ISupplierPaymentService
    {
        private readonly ISupplierPaymentDal _supplierPaymentDal = new EfSupplierPaymentDal();
        public IResult Add(SupplierPayment supplierPayment)
        {
            _supplierPaymentDal.Add(supplierPayment);
            return new SuccessResult();
        }

        public IResult Delete(SupplierPayment supplierPayment)
        {
            _supplierPaymentDal.Delete(supplierPayment);
            return new SuccessResult();
        }

        public IDataResult<SupplierPaymentDto> GetBySupplierPaymentId(int id)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<SupplierPaymentDto>> GetListSupplierPayment()
        {
            return new SuccessDataResult<List<SupplierPaymentDto>>(_supplierPaymentDal.GetListSupplierPayment());
        }

        public IResult Update(SupplierPayment supplierPayment)
        {
            _supplierPaymentDal.Update(supplierPayment);
            return new SuccessResult();
        }
    }
}