using MarketProject.Core.Utilities.Results;
using MarketProject.Entities.Concrete;
using MarketProject.Entities.Dtos;
using System.Collections.Generic;

namespace MarketProject.Business.Abstract
{
    public interface ISupplierPaymentService
    {
        IResult Add(SupplierPayment supplierPayment);
        IResult Update(SupplierPayment supplierPayment);
        IResult Delete(SupplierPayment supplierPayment);
        IDataResult<List<SupplierPaymentDto>> GetListSupplierPayment();
        IDataResult<SupplierPaymentDto> GetBySupplierPaymentId(int id);
    }
}
