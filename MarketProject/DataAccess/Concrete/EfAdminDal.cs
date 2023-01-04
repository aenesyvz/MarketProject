using MarketProject.Core.DataAccess.EntityFramework;
using MarketProject.DataAccess.Abstract;
using MarketProject.DataAccess.Concrete.Context;
using MarketProject.Entities.Concrete;
using System;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject.DataAccess.Concrete
{
    public class EfAdminDal : EfEntityRepositoryBase<Admin, ContextDb>, IAdminDal
    {

    }
}
