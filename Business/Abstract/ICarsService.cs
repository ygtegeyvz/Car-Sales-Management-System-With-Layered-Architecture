using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarsService
    {
        List<Cars> GetAll();
        void Delete(Cars cars);
        List<Cars> GetCarsByColor(int RenkID);
        List<Cars> GetCarsByGear(int GearID);
        List<Cars> GetCarsByFuel(int FuelID);
    }
}
