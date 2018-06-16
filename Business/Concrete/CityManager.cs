using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
   public class CityManager:ICityService
    {
        private ICityDal _CityDal;

        public CityManager(ICityDal cityService)
        {
            _CityDal = cityService;
        }

        public List<City> GetAll()
        {
            return _CityDal.GetAll();
        }
    }
}
