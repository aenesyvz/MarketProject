using MarketProject.Core.DataAccess.EntityFramework;
using MarketProject.DataAccess.Abstract;
using MarketProject.DataAccess.Concrete.Context;
using MarketProject.Entities.Concrete;
using MarketProject.Entities.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace MarketProject.DataAccess.Concrete
{
    public class EfSupplierPaymentDal : EfEntityRepositoryBase<SupplierPayment, ContextDb>, ISupplierPaymentDal
    {
        public List<SupplierPaymentDto> GetListSupplierPayment()
        {
            using (var context = new ContextDb())
            {
                var items = from p in context.SupplierPayments
                            join s in context.Suppliers on p.SupplierId equals s.Id
                            join d in context.DebtSuppliers on p.DebtSupplierId equals d.Id
                            select new SupplierPaymentDto()
                            {
                                SupplierFirstName = s.FirstName,
                                SupplierLastName = s.LastName,
                                SupplierPhoneNumber = s.PhoneNumber,
                                DebtSupplierId = d.Id,
                                Payment = p.Payment,
                                AddedPayment = p.AddedPayment
                            };
                return items.ToList();
            }
        }
    }
}
