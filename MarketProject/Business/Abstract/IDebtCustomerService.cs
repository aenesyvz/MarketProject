using MarketProject.Core.Utilities.Results;
using MarketProject.Entities.Concrete;
using MarketProject.Entities.Dtos;
using System.Collections.Generic;

namespace MarketProject.Business.Abstract
{
    public interface IDebtCustomerService
    {
        IResult Add(DebtCustomer debtCustomer);
        IResult Update(DebtCustomer debtCustomer);
        IResult Delete(DebtCustomer debtCustomer);
        IDataResult<DebtCustomer> AddToMap(DebtCustomer debtCustomer);
        IDataResult<List<DebtCustomer>> GetList();
        IDataResult<DebtCustomer> GetById(int id);
        IDataResult<CustomerTotalDebtDto> GetTotalDebtByCustomerId(int customerId);
        IDataResult<List<CustomerTotalDebtDto>> GetListCustomerTotalDebt();
        IDataResult<List<DebtCustomer>> GetListByCustomerId(int customerId);
    }
}
