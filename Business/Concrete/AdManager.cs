using System;
using System.Collections.Generic;
using System.Linq;
using Business.Abstract;
using Business.Utilities;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AdManager:IAdService
    {
        private IAdDal _adService;

        public AdManager(IAdDal adService)
        {
            _adService = adService;
        }

        public List<Ad> GetAll()
        {
            return _adService.GetAll();
        }

        public void Add(Ad ad)
        {
            ValidationTools.Validation(new AdValidation(), ad);
          _adService.Add(ad);
        }

        public void Update(Ad ad)
        {
            ValidationTools.Validation(new AdValidation(), ad);
            _adService.Update(ad);
        }

        public void Delete(Ad ad)
        {
            _adService.Delete(ad);
        }

        public List<Ad> GetAdByCity(int CityId)
        {
            return _adService.GetAll(p => p.Ilan_SehirID == CityId);
        }

        public List<Ad> GetAdByAdName(string nameSearchText)
        {
           
            return _adService.GetAll(p => p.Ilan_Adi.ToLower().Contains(nameSearchText.ToLower()));
        }

        public List<Ad> GetAdByCarsId(List<Cars> getCarsByColor)
        {
            List<Ad> adList = new List<Ad>();
            List<Ad> temporaryList= new List<Ad>();
            foreach (var cars in getCarsByColor)
            {
           temporaryList=_adService.GetAll(p => p.Ilan_ArabaID == cars.ArabaID);
                foreach (var temporaryAd in temporaryList)
                {
                    adList.Add(temporaryAd);
                }
            }

            return adList;
        }

        public List<Ad> GetAdByAdKm(string minKm, string maxKm)
        {
            int minkm = Convert.ToInt32(minKm);
            int maxkm = Convert.ToInt32(maxKm);
            return _adService.GetAll(p => p.Ilan_Km >= minkm && p.Ilan_Km<= maxkm);
        }

        public List<Ad> GetAdByAdPrice(string minPrice, string maxPrice)
        {
            decimal minprice = Convert.ToDecimal(minPrice);
            decimal maxprice = Convert.ToDecimal(maxPrice);
            return _adService.GetAll(p => p.Ilan_Fiyat >= minprice && p.Ilan_Fiyat <= maxprice);
        }

        //public List<Ad> GetAdByUpToDown()
        //{
        //    //CarsCompanyContext carsCompanyContext= new CarsCompanyContext();
        //    //_adService.GetAll(from p in carsCompanyContext.Ads orderby p.Ilan_Adi select p);
        //    //return _adService.GetAll(p => p.Ilan_Adi.OrderBy( ));
        //}

        public List<Ad> GetAdbByCityandName(int CityId,string Name)
        {
            return _adService.GetAll(p => p.Ilan_SehirID == CityId && p.Ilan_Adi.ToLower().Contains(Name));
        }
    }
}
