using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Abstract
{
  public  interface IUsersDal:IEntityRepository<Users>
  {
      bool isValidLogin(string userName, string password);
  }
}
