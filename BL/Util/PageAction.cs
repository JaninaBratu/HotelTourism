using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Util
{
    public class PageAction
    {

        public static double GetNrOfPages(int nrOfHotels, int pageLimit)
        {
            float pageNumber = (nrOfHotels + pageLimit -1) / pageLimit;
            double pageNr = System.Convert.ToDouble(pageNumber);
            return pageNr;
            //return Math.Round(pageNr, 0, MidpointRounding.AwayFromZero);
            //return (int)Math.Ceiling(pageNr);
        }

        //pageLimit = items per page
        public static double CalculateOffset(int currentPage, int pageLimit)
        {
            double tempOffset = System.Convert.ToDouble(currentPage - 1);
            double finalOffset = System.Convert.ToDouble(tempOffset * pageLimit);

            return finalOffset;
        }
    }
}
