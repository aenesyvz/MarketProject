using MarketProject.Core.Utilities.Results;
using MarketProject.Entities.Concrete;
using System.Collections.Generic;

namespace MarketProject.Business.Abstract
{
    public interface IProductService
    {
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);
        IDataResult<List<Product>> GetList();
        IDataResult<Product> GetById(int id);
        IDataResult<Product> GetByCode(string code);
        IDataResult<Product> GetByBarcode(string code);
    }
}
