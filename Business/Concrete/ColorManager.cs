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
   public class ColorManager:IColorService
    {
        private IColorsDal _colorDal;

        public ColorManager(IColorsDal colorService)
        {
            _colorDal = colorService;
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }
    }
}
