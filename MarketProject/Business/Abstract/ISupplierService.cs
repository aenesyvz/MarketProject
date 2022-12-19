using MarketProject.Core.Utilities.Results;
using MarketProject.Entities.Concrete;
using System.Collections.Generic;

namespace MarketProject.Business.Abstract
{
    public interface ISupplierService
    {
        IResult Add(Supplier supplier);
        IResult Update(Supplier supplier);
        IResult Delete(Supplier supplier);
        IDataResult<List<Supplier>> GetList();
        IDataResult<Supplier> GetById(int id);
        IDataResult<Supplier> GetByPhoneNumberLike(string phoneNumber);
    }
}
