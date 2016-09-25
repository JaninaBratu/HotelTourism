using DAL;
using DAL.Repositories;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CityService
    {

        public static List<City> GetAllCities()
        {
            return CityRepository.GetAllCities();
        }

        public static List<City> GetCitiesByCounty(int countyId)
        {
            return CityRepository.GetCitiesByCounty(countyId);
        }
    }
}
