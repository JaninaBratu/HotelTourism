using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CityRepository
    {
        public static List<City> GetAllCities()
        {
            try
            {
                using (var context = new ModelContext())
                {
                    return context.Cities.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<City> GetCitiesByCounty(int countyId)
        {
            try
            {
                using (var context = new ModelContext())
                {
                    return context.Cities.Where(c => c.County.CountyId == countyId).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
