using MarketProject.Business.Abstract;
using MarketProject.Core.Utilities.Results;
using MarketProject.DataAccess.Abstract;
using MarketProject.DataAccess.Concrete;
using MarketProject.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace MarketProject.Business.Concrete
{
    public class SaleManager : ISaleService
    {
        private readonly ISaleDal _saleDal = new EfSaleDal();

        public IResult Add(Sale sale)
        {
            _saleDal.Add(sale);
            return new SuccessResult();
        }

        public IDataResult<Sale> AddToMap(Sale sale)
        {
            return new SuccessDataResult<Sale>(_saleDal.AddMap(sale));
        }

        public IResult Delete(Sale sale)
        {
            _saleDal.Delete(sale);
            return new SuccessResult();
        }

        public IDataResult<Sale> GetById(int id)
        {
            return new SuccessDataResult<Sale>(_saleDal.Get(x => x.Id == id));
        }

        public IDataResult<List<Sale>> GetList()
        {
            return new SuccessDataResult<List<Sale>>(_saleDal.GetList().ToList());
        }

        public IResult Update(Sale sale)
        {
            _saleDal.Update(sale);
            return new SuccessResult();
        }
    }
}
