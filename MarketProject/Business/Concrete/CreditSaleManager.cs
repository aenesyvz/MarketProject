using MarketProject.Business.Abstract;
using MarketProject.Core.Utilities.Results;
using MarketProject.DataAccess.Abstract;
using MarketProject.DataAccess.Concrete;
using MarketProject.Entities.Concrete;
using MarketProject.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarketProject.Business.Concrete
{
    public class CreditSaleManager : ICreditSaleService
    {
        private readonly ICreditSaleDal _creditSaleDal = new EfCreditSaleDal();
        private readonly ISaleService _saleService = new SaleManager();
        private readonly IDebtCustomerService debtCustomerService = new DebtCustomerManager();
        public IResult Add(CreditSale creditSale)
        {
            _creditSaleDal.Add(creditSale);
            return new SuccessResult();
        }

        public IResult Delete(CreditSale creditSale)
        {
            _creditSaleDal.Delete(creditSale);
            return new SuccessResult();
        }

        public IDataResult<CreditSale> GetById(int saleId)
        {
            var response = _creditSaleDal.Get(x => x.SaleId == saleId);
            if(response == null)
            {
                return new ErrorDataResult<CreditSale>("Satış bulunamadı");
            }
            return new SuccessDataResult<CreditSale>(response);
        }

        public IDataResult<List<CreditSaleDto>> GetListByDebtCustomerId(int debtCustomerId)
        {
            return new SuccessDataResult<List<CreditSaleDto>>(_creditSaleDal.GetCreditSaleDtos(debtCustomerId).ToList());
        }
    }
}
