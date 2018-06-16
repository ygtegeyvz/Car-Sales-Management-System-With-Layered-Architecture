using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IAdService
 {
     List<Ad> GetAll();
        void Add(Ad ad);
        void Update(Ad ad);
     void Delete(Ad ad);
     List<Ad> GetAdByCity(int CityId);
     List<Ad> GetAdByAdName(string nameSearchText);
     List<Ad> GetAdByCarsId(List<Cars> getCarsByColor);
     List<Ad> GetAdByAdKm(string minKm, string maxKm);
     List<Ad> GetAdByAdPrice(string minPrice, string maxPrice);
     List<Ad> GetAdbByCityandName(int CityId, string Name);
     // List<Ad> GetAdByUpToDown();
 }
}
