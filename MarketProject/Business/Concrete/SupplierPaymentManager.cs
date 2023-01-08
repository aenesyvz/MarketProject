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

        //ÇALIŞAN KOD
        public IResult Update(SupplierPayment supplierPayment)
        {
            _supplierPaymentDal.Update(supplierPayment);
            return new SuccessResult();
        }


        // Business Rules

        /*public IResult Update(SupplierPayment supplierPayment)
        {
            IResult result = BusinessRules.Run(CheckIfDebtExists(supplierPayment.Payment));
            if (result != null)
            {
                return result;
            }
            _supplierPaymentDal.Update(supplierPayment);
            return new SuccessResult();
        }
        private IResult CheckIfDebtExists(decimal Payment)
        {
            var result = _supplierPaymentDal .GetList(x => x.Payment == Payment).ToList().Any();
            if (result)
            {
                return new ErrorResult("Tedarikçinin ödenmemiş bir borcu vardır. Tedarikçi silinemez!");
            }
            return new SuccessResult();
        }*/
    }
}