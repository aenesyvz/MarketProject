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
    public class DebtCustomerManager : IDebtCustomerService
    {
        private readonly IDebtCustomerDal _debtCustomerDal = new EfDebtCustomerDal();
        private readonly ICustomerService _customerService = new CustomerManager();
        public IResult Add(DebtCustomer debtCustomer)
        {
            _debtCustomerDal.Add(debtCustomer);
            return new SuccessResult();
        }

        public IResult Delete(DebtCustomer debtCustomer)
        {
            _debtCustomerDal.Delete(debtCustomer);
            return new SuccessResult();
        }

        public IDataResult<DebtCustomer> GetById(int id)
        {
            return new SuccessDataResult<DebtCustomer>(_debtCustomerDal.Get(x => x.Id == id));
        }

        public IDataResult<List<DebtCustomer>> GetList()
        {
            return new SuccessDataResult<List<DebtCustomer>>(_debtCustomerDal.GetList().ToList());
        }

        public IDataResult<CustomerTotalDebtDto> GetTotalDebtByCustomerId(int customerId)
        {
            Customer customer = _customerService.GetById(customerId).Data;
            decimal _debt = _debtCustomerDal.GetList(x => x.CustomerId == customer.Id).ToList().Sum(y => y.AmountOfDebt);
            decimal _paid = _debtCustomerDal.GetList(x => x.CustomerId == customer.Id).ToList().Sum(y => y.AmountPaid);
            decimal _remaing = _debtCustomerDal.GetList(x => x.CustomerId == customer.Id).ToList().Sum(y => y.RemaingDebt);

            CustomerTotalDebtDto customerTotalDebt = new CustomerTotalDebtDto()
            {
                CustomerId = customer.Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                AmountOfDebt = _debt,
                AmountPaid = _paid,
                PhoneNumber = customer.PhoneNumber,
                RemaingDebt = _debt,
            };
            return new SuccessDataResult<CustomerTotalDebtDto>(customerTotalDebt);
        }

        public IDataResult<List<CustomerTotalDebtDto>> GetListCustomerTotalDebt()
        {
            List<Customer> customers = _customerService.GetList().Data;

            var items = customers.Select(x => new CustomerTotalDebtDto()
            {
                CustomerId = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                AmountOfDebt = _debtCustomerDal.GetList(y => y.CustomerId == x.Id).ToList().Sum(z => z.AmountOfDebt),
                AmountPaid = _debtCustomerDal.GetList(y => y.CustomerId == x.Id).ToList().Sum(z => z.AmountPaid),
                PhoneNumber = x.PhoneNumber,
                RemaingDebt = _debtCustomerDal.GetList(y => y.CustomerId == x.Id).ToList().Sum(z => z.RemaingDebt)
            }
            ).ToList();
            return new SuccessDataResult<List<CustomerTotalDebtDto>>(items);
        }

        public IResult Update(DebtCustomer debtCustomer)
        {
            _debtCustomerDal.Update(debtCustomer);
            return new SuccessResult();
        }
    }
}
