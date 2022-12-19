using MarketProject.Core.DataAccess;
using MarketProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject.DataAccess.Abstract
{
    public interface IAdminDal : IEntityRepository<Admin>
    {

    }
}
