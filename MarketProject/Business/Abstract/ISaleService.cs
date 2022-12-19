using MarketProject.Core.Utilities.Results;
using MarketProject.Entities.Concrete;
using MarketProject.Entities.Dtos;
using System.Collections.Generic;

namespace MarketProject.Business.Abstract
{
    public interface ISaleService
    {
        IResult Add(Sale sale);
        IResult Update(Sale sale);
        IResult Delete(Sale sale);
        IDataResult<List<Sale>> GetList();
        IDataResult<Sale> GetById(int id);
        IDataResult<Sale> AddToMap(Sale sale);
        IDataResult<List<Sale>> GetListDesc();
        IDataResult<List<SaleProductDto>> GetListSaleProductDesc();
    }
}
