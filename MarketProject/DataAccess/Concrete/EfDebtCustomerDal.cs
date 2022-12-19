using MarketProject.Core.DataAccess.EntityFramework;
using MarketProject.DataAccess.Abstract;
using MarketProject.DataAccess.Concrete.Context;
using MarketProject.Entities.Concrete;

namespace MarketProject.DataAccess.Concrete
{
    public class EfDebtCustomerDal : EfEntityRepositoryBase<DebtCustomer, ContextDb>, IDebtCustomerDal
    {
        //public List<CustomerTotalDebt> GetListCustomersDebtTotal(User user)
        //{
        //    using (var context = new ContextDb())
        //    {
        //        var result = from customer in context.Customers
        //                     join debtCustomer in context.DebtCustomers
        //                     on customer.Id equals debtCustomer.CustomerId
        //                     select new CustomerTotalDebt
        //                     {
        //                         CustomerId = customer.Id,
        //                         FirstName = customer.FirstName,
        //                         LastName = customer.LastName,
        //                         AmountOfDebt = _debt,
        //                         AmountPaid = _paid,
        //                         PhoneNumber = customer.PhoneNumber,
        //                         RemaingDebt = _debt,
        //                     };
        //        return result.ToList();
        //    }
        //}
    }
}
