using MarketProject.Business.Abstract;
using MarketProject.Core.Utilities.Results;
using MarketProject.DataAccess.Abstract;
using MarketProject.DataAccess.Concrete;
using MarketProject.Entities.Concrete;
using MarketProject.Entities.Dtos;
using System.Collections.Generic;

namespace MarketProject.Business.Concrete
{
    public class CustomerPaymentManager : ICustomerPaymentService
    {
        private readonly ICustomerPaymentDal _customerPaymentDal = new EfCustomerPaymentDal();
        public IResult Add(CustomerPayment customerPayment)
        {
            _customerPaymentDal.Add(customerPayment);
            return new SuccessResult();
        }

        public IResult Delete(CustomerPayment customerPayment)
        {
            _customerPaymentDal.Delete(customerPayment);
            return new SuccessResult();
        }

        public IDataResult<CustomerPaymentDto> GetByCustomerPaymentId(int id)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<CustomerPaymentDto>> GetListCustomerPayment()
        {
            return new SuccessDataResult<List<CustomerPaymentDto>>(_customerPaymentDal.GetListCustomerPayment());
        }

        public IResult Update(CustomerPayment customerPayment)
        {
            _customerPaymentDal.Update(customerPayment);
            return new SuccessResult();
        }
    }
}
