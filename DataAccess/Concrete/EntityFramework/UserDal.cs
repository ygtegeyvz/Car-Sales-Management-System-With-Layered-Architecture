using System.Linq;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class UserDal:EfEntityRepositoryBase<Users,CarsCompanyContext>,IUsersDal
    {
        public static bool isValidLogin(string userName, string password)
        {
            using (CarsCompanyContext db = new CarsCompanyContext())
            {
                Users user = (from u in db.Users
                    where u.UserName.Equals(userName)
                    select u).FirstOrDefault();

                if (user == null)
                {
                    return false;
                }
                else if (!user.Password.Equals(password))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        bool IUsersDal.isValidLogin(string userName, string password)
        {
            return isValidLogin(userName, password);
        }
    }
}
