using MarketProject.Core.Utilities.Results;
using MarketProject.Entities.Concrete;
using MarketProject.Entities.Dtos;
using System.Collections.Generic;

namespace MarketProject.Business.Abstract
{
    public interface ICustomerPaymentService
    {
        IResult Add(CustomerPayment customerPayment);
        IResult Update(CustomerPayment customerPayment);
        IResult Delete(CustomerPayment customerPayment);
        IDataResult<List<CustomerPaymentDto>> GetListCustomerPayment();
        IDataResult<CustomerPaymentDto> GetByCustomerPaymentId(int id);
    }
}
