using MarketProject.Core.Utilities.Results;
using MarketProject.Entities.Concrete;
using System.Collections.Generic;

namespace MarketProject.Business.Abstract
{
    public interface IWaybillService
    {
        IResult Add(Waybill waybill);
        IResult Update(Waybill waybill);
        IResult Delete(Waybill waybill);
        IDataResult<List<Waybill>> GetList();
        IDataResult<Waybill> GetById(int id);
    }
}
