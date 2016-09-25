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
    public class CountyService
    {

        public static List<County> GetAllCounties()
        {
            return CountyRepository.GetAllCounties();
        }

    }
}
