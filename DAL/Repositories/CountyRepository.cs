using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CountyRepository
    {

        public static List<County> GetAllCounties()
        {
            try
            {
                using (var context = new ModelContext())
                {
                    return context.Counties.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
