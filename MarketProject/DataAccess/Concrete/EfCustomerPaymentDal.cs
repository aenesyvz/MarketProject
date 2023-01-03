using MarketProject.Core.DataAccess.EntityFramework;
using MarketProject.DataAccess.Abstract;
using MarketProject.DataAccess.Concrete.Context;
using MarketProject.Entities.Concrete;
using MarketProject.Entities.Dtos;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MarketProject.DataAccess.Concrete
{
    public class EfCustomerPaymentDal : EfEntityRepositoryBase<CustomerPayment, ContextDb>, ICustomerPaymentDal
    {
        public List<CustomerPaymentDto> GetListCustomerPayment()
        {
            using (var context = new ContextDb())
            {
                var items = from p in context.CustomerPayments
                            join c in context.Customers on p.CustomerId equals c.Id
                            join d in context.DebtCustomers on p.DebtCustomerId equals d.Id
                            select new CustomerPaymentDto()
                            {
                                CustomerFirstName = c.FirstName,
                                CustomerLastName = c.LastName,
                                CustomerPhoneNumber = c.PhoneNumber,
                                DebtCustomerId = d.Id,
                                Payment = p.Payment,
                                AddedPayment = p.AddedPayment
                            };
                return items.ToList();
            }
        }
    }
}
