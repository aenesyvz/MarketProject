using MarketProject.Business.Abstract;
using MarketProject.Core.Utilities.Results;
using MarketProject.DataAccess.Abstract;
using MarketProject.DataAccess.Concrete;
using MarketProject.Entities.Concrete;
using MarketProject.Entities.Dtos;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;

namespace MarketProject.Business.Concrete
{
    public class SaleManager : ISaleService
    {
        private readonly ISaleDal _saleDal = new EfSaleDal();
        private readonly IProductService _productService = new ProductManager();

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

        public IDataResult<List<Sale>> GetListDesc()
        {
            return new SuccessDataResult<List<Sale>>(_saleDal.GetList().ToList());
        }

        public IDataResult<List<SaleProductDto>> GetListSaleProductDesc()
        {
            List<Sale> sales = _saleDal.GetList().ToList();
            var items = sales.Select(x => new SaleProductDto()
            {
                ProductId = x.ProductId,
                BarcodeNo = _productService.GetById(x.ProductId).Data.BarcodeNo,
                Code = _productService.GetById(x.ProductId).Data.Code,
                Name = _productService.GetById(x.ProductId).Data.Name,
                Total = _saleDal.GetList(y => y.ProductId == x.ProductId).ToList().Sum(z => z.Amount)
            }).ToList().OrderByDescending(f => f.Total) ;
            return new SuccessDataResult<List<SaleProductDto>>(items.ToList());
        }

        public IResult Update(Sale sale)
        {
            _saleDal.Update(sale);
            return new SuccessResult();
        }
    }
}
