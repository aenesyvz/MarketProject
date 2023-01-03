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
    public class EfProductDal : EfEntityRepositoryBase<Product, ContextDb>, IProductDal
    {
        private readonly ISaleDal _saleDal = new EfSaleDal();
        private readonly IWaybillDal _waybillDal = new EfWaybillDal();
        public List<ProductProfitAndDamageDto> GetListProductProfitAndDamage()
        {
            using (var context = new ContextDb())
            {
                var items = from p in context.Products
                            //join w in context.Waybills on p.Code equals w.ProductCode
                          //  join s in context.Sales on p.Id equals s.ProductId
                            select new ProductProfitAndDamageDto()
                            {
                                Barcode = p.BarcodeNo,
                                ProductName = p.Name,
                                Result = (context.Sales.Where(x => x.ProductId == p.Id).ToList().Select(q => q.Price).Sum() != null ? context.Sales.Where(x => x.ProductId == p.Id).ToList().Select(q => q.Price).Sum():0 ) - (context.Waybills.Where(y => y.ProductCode == p.Code).ToList().Select(z => z.TotalPrice).Sum() != null ? context.Waybills.Where(y => y.ProductCode == p.Code).ToList().Select(z => z.TotalPrice).Sum() : 0)
                            };
                return items.ToList();
                //RESULT MUHAKKAK REFACTORİNG YAPILMALI HOJ DEGIL 
            }
        }
    }
}

// - _waybillDal.GetList(y => y.ProductCode == w.ProductCode).ToList().Select(y => y.TotalPrice).Sum()
// - context.Waybills.Where(y => y.ProductCode == p.Code).ToList().Select(z => z.TotalPrice).Sum()