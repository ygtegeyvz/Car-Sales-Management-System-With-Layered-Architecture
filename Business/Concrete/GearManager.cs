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
    public class GearManager : IGearService
    {
        private IGearDal _gearDal;

        public GearManager(IGearDal gearDal)
        {
            _gearDal = gearDal;
        }

        public List<Gear> GetAll()
        {
            return _gearDal.GetAll();
        }
    }
}
