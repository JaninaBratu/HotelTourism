using BL.Util;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class HotelRepository
    {

        public static List<Hotel> GetListOfHotels()
        {
            try
            {
                var context = new ModelContext();
                return context.Hotels.ToList();
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int GetTotalNrOfHotels(FilterType filterType)
        {
            try
            {
                var context = new ModelContext();
                //refactor
                if (filterType.County > 0)
                {
                    return context.Hotels.Where(h => h.City.County.CountyId == filterType.County).ToList().Count;
                }
                else
                {
                    return context.Hotels.ToList().Count;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Hotel> GetListByOffsetAndFilterType(int limit, double offset, FilterType filterType)
        {
            try
            {
                var context = new ModelContext();

                var result = (from h in context.Hotels
                              join cnt in context.Counties
                              on h.City.County.CountyId equals cnt.CountyId
                              select h)
                              ;

                if (filterType.County > 0)
                {
                    result = result.Where(h=> h.City.County.CountyId == filterType.County);
                }
                if (filterType.City > 0)
                {
                    result = result.Where(h => h.City.CityId == filterType.City);
                }

                return result.OrderBy(h => h.HotelId)
                                    .Skip(Convert.ToInt32(offset))
                                    .Take(limit).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }


     }
}
