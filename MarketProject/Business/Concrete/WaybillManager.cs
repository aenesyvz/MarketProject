using MarketProject.Business.Abstract;
using MarketProject.Core.Utilities.Results;
using MarketProject.DataAccess.Abstract;
using MarketProject.DataAccess.Concrete;
using MarketProject.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace MarketProject.Business.Concrete
{
    public class WaybillManager : IWaybillService
    {
        private readonly IWaybillDal _waybillDal = new EfWaybillDal();

        public IResult Add(Waybill waybill)
        {
            _waybillDal.Add(waybill);
            return new SuccessResult();
        }

        public IResult Delete(Waybill waybill)
        {
            _waybillDal.Delete(waybill);
            return new SuccessResult();
        }

        public IDataResult<Waybill> GetById(int id)
        {
            return new SuccessDataResult<Waybill>(_waybillDal.Get(x => x.Id == id));
        }

        public IDataResult<List<Waybill>> GetList()
        {
            return new SuccessDataResult<List<Waybill>>(_waybillDal.GetList().ToList());
        }

        public IResult Update(Waybill waybill)
        {
            _waybillDal.Update(waybill);
            return new SuccessResult();
        }
    }
}
