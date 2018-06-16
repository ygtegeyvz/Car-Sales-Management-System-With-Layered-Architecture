using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class CarManager:ICarsService
    {
        private ICarsDal _carsDal;

        public CarManager(ICarsDal carsService)
        {
            _carsDal = carsService;
        }

        public List<Cars> GetAll()
        {
            return _carsDal.GetAll();
        }

        public void Delete(Cars cars)
        {
            _carsDal.Delete(cars);
        }

        public List<Cars> GetCarsByColor(int RenkID)
        {
          return _carsDal.GetAll(p => p.Araba_RenkID == RenkID);
        }

        public List<Cars> GetCarsByGear(int GearID)
        {
            return _carsDal.GetAll(p => p.Araba_VitesTuruID == GearID);
        }

        public List<Cars> GetCarsByFuel(int FuelID)
        {
            return _carsDal.GetAll(p => p.Araba_YakitTuruID == FuelID);
        }
    }
}
