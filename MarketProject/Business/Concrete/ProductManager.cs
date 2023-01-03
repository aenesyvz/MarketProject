using MarketProject.Business.Abstract;
using MarketProject.Core.Utilities.Results;
using MarketProject.DataAccess.Abstract;
using MarketProject.DataAccess.Concrete;
using MarketProject.Entities.Concrete;
using MarketProject.Entities.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace MarketProject.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal = new EfProductDal();

        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult();
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult();
        }

        public IDataResult<Product> GetByBarcode(string barcode)
        {
            return new SuccessDataResult<Product>(_productDal.Get(x => x.BarcodeNo == barcode));
        }

        public IDataResult<Product> GetByCode(string code)
        {
            return new SuccessDataResult<Product>(_productDal.Get(x => x.Code == code));
        }

        public IDataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(x => x.Id == id));
        }

        public IDataResult<List<Product>> GetList()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList().ToList());
        }

        public IDataResult<List<Product>> GetListLowStockProduct()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList().Where(x => x.Amount < 100).ToList());
        }

        public IDataResult<List<ProductProfitAndDamageDto>> GetListProductProfitAndDamage()
        {
            return new SuccessDataResult<List<ProductProfitAndDamageDto>>(_productDal.GetListProductProfitAndDamage());
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult();
        }
    }
}
