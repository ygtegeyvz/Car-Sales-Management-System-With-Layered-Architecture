using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
namespace DataAccess.Concrete
{// Bu katmanda sadece veri tabanı işlemleri yapıldı.
    public class CarsDal : EfEntityRepositoryBase<Cars, CarsCompanyContext>, ICarsDal
    {
       
    }
}
