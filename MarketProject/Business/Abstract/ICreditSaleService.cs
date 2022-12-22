using MarketProject.Core.Utilities.Results;
using MarketProject.Entities.Concrete;
using MarketProject.Entities.Dtos;
using System.Collections.Generic;

namespace MarketProject.Business.Abstract
{
    public interface ICreditSaleService
    {
        IResult Add(CreditSale creditSale);
        IDataResult<List<CreditSaleDto>> GetListByDebtCustomerId(int debtcustomerId);
        IDataResult<CreditSale> GetById(int saleId);
        IResult Delete(CreditSale creditSale);
    }
}
