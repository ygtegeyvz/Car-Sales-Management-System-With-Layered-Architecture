using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace Business.DependencyResolver.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IAdService>().To<AdManager>();
            Bind<IAdDal>().To<AdDal>();

            Bind<ICarsService>().To<CarManager>();
            Bind<ICarsDal>().To<CarsDal>();

            Bind<IGearService>().To<GearManager>();
            Bind<IGearDal>().To<GearDal>();

            Bind<IFuelService>().To<FuelManager>();
            Bind<IFuelDal>().To<FuelDal>();

            Bind<ICityService>().To<CityManager>();
            Bind<ICityDal>().To<CityDal>();

            Bind<IUserService>().To<UserManager>();
            Bind<IUsersDal>().To<UserDal>();

            Bind<IColorService>().To<ColorManager>();
            Bind<IColorsDal>().To<ColorDal>();
        }
    }
}
