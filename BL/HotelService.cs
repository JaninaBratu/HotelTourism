using BL.Util;
using DAL.Repositories;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class HotelService
    {

        public static List<Hotel> GetListOfHotels()
        {
            return HotelRepository.GetListOfHotels();
        }

        public static int GetTotalNrOfHotels(FilterType filterType)
        {
            return HotelRepository.GetTotalNrOfHotels(filterType);
        }

        public static List<Hotel> GetListByOffsetAndFilterType(int limit, double offset, FilterType filterType)
        {
            return HotelRepository.GetListByOffsetAndFilterType(limit, offset, filterType);
        }
        
    }
}
