using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager:IUserService
   {
       private IUsersDal _usersDal;

       public UserManager(IUsersDal usersDal)
       {
           _usersDal = usersDal;
       }
        public List<Users> GetAll()
        {
           
            return _usersDal.GetAll();
        }

        public bool isValidLogin(string userName,string password)
        {       
             return _usersDal.isValidLogin(userName,password);
        }
    }
}
