using MarketProject.Business.Abstract;
using MarketProject.Business.Concrete;
using MarketProject.Core.DataAccess.EntityFramework;
using MarketProject.DataAccess.Abstract;
using MarketProject.DataAccess.Concrete.Context;
using MarketProject.Entities.Concrete;
using MarketProject.Entities.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace MarketProject.DataAccess.Concrete
{
    public class EfCreditSaleDal : EfEntityRepositoryBase<CreditSale, ContextDb>, ICreditSaleDal
    {
        private readonly IProductDal _productDal = new EfProductDal();
        public List<CreditSaleDto> GetCreditSaleDtos(int debtCustomerId)
        {
            using (var context = new ContextDb())
            {
                var items = from cs in context.CreditSales
                            join s in context.Sales on cs.SaleId equals s.Id
                            join c in context.Customers on cs.CustomerId equals c.Id
                            join db in context.DebtCustomers on cs.DebtCustomerId equals db.Id
                            join p in context.Products on s.ProductId equals p.Id
                            where cs.DebtCustomerId == debtCustomerId
                            select new CreditSaleDto()
                            {
                                DebtCustomerId= debtCustomerId,
                                SaleId= s.Id,
                                Amount = s.Amount,
                                Price = s.Price,
                                CustomerId= c.Id,
                                PhoneNumber = c.PhoneNumber,
                                FirstName = c.FirstName,
                                LastName = c.LastName,
                                ProdutctId = s.ProductId,
                                Name = p.Name,
                                BarcodeNo = p.BarcodeNo,
                                DebtDate = db.AddedDate
                            };
                return items.ToList();
            }
        }
    }
}
