using MarketProject.Business.Abstract;
using MarketProject.Core.Utilities.Business;
using MarketProject.Core.Utilities.Results;
using MarketProject.DataAccess.Abstract;
using MarketProject.DataAccess.Concrete;
using MarketProject.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MarketProject.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal = new EfCustomerDal();
        //public CustomerManager(ICustomerDal customerDal)
        //{
        //    _customerDal = customerDal;
        //}
        public IResult Add(Customer customer)
        {
            IResult result = BusinessRules.Run(CheckIfPhoneNumberExists(customer.PhoneNumber));
            if(result != null)
            {
                return result;
            }
            _customerDal.Add(customer);
            return new SuccessResult();
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult();
        }

        public IDataResult<Customer> GetById(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(x => x.Id == id));
        }

        public IDataResult<Customer> GetByPhoneNumber(string phoneNumber)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(x => x.PhoneNumber == phoneNumber));
        }

        public IDataResult<List<Customer>> GetList()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetList().ToList());
        }

        public IResult Update(Customer customer)
        {
            IResult result = BusinessRules.Run(CheckIfPhoneNumberExists(customer.PhoneNumber));
            if (result != null)
            {
                return result;
            }
            _customerDal.Update(customer);
            return new SuccessResult();
        }



        //Business Rules

        private IResult CheckIfPhoneNumberExists(string phoneNumber)
        {
            var result = _customerDal.GetList(x => x.PhoneNumber == phoneNumber).ToList().Any();
            if(result)
            {
                return new ErrorResult("Bu telefon numarasına ait bir müşteri zaten bulunmaktadır!");
            }
            return new SuccessResult();
        }
    }
}
