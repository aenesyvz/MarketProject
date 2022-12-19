using MarketProject.Core.Utilities.Results;
using MarketProject.Entities.Concrete;
using System.Collections.Generic;

namespace MarketProject.Business.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IResult Delete(Customer customer);
        IDataResult<List<Customer>> GetList();
        IDataResult<Customer> GetById(int id);
    }
}
