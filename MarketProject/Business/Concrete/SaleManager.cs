using MarketProject.Business.Abstract;
using MarketProject.Core.Utilities.Results;
using MarketProject.DataAccess.Abstract;
using MarketProject.DataAccess.Concrete;
using MarketProject.Entities.Concrete;
using MarketProject.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
          
            List<SaleProductDto> sales = _saleDal.GetList().GroupBy(l => l.ProductId).Select(c => new SaleProductDto
            {
                ProductId = c.Key,
                BarcodeNo = _productService.GetById(c.Key).Data.BarcodeNo,
                Code = _productService.GetById(c.Key).Data.Code,
                Name = _productService.GetById(c.Key).Data.Name,
                Total = c.Sum(p => p.Amount)
            }).OrderByDescending(x=>x.Total).ToList();
            return new SuccessDataResult<List<SaleProductDto>>(sales);
        }

        public IDataResult<List<SaleTrendByDateDto>> GetListSaleTrendByDate(DateTime start, DateTime finish)
        {
            List<SaleTrendByDateDto> saleTrendByDateDtos = _saleDal.GetList().Where(x => x.AddedDate.Day >= start.Day && x.AddedDate.Day <= finish.Day).GroupBy(l => l.AddedDate.Day).Select(c => new SaleTrendByDateDto
            {
                SaleDate = c.First().AddedDate.Date,
                Sum = c.Sum(p => p.Amount)
            }).ToList() ;
          
            return new SuccessDataResult<List<SaleTrendByDateDto>>(saleTrendByDateDtos);
        }

        public IResult Update(Sale sale)
        {
            _saleDal.Update(sale);
            return new SuccessResult();
        }
    }
}
