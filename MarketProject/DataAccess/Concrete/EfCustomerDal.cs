using MarketProject.Core.DataAccess.EntityFramework;
using MarketProject.DataAccess.Abstract;
using MarketProject.DataAccess.Concrete.Context;
using MarketProject.Entities.Concrete;

namespace MarketProject.DataAccess.Concrete
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, ContextDb>, ICustomerDal
    {

    }
}
