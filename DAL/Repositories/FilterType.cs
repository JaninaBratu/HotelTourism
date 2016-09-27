using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Util
{
    public class FilterType
    {

        public int County { get; set; }
        public int City { get; set; }
        //public DateTime DateFrom { get; set; }
        //public DateTime DateTill { get; set; }

        //public int AirConditioner { get; set; }
        //public int PlasmaTV { get; set; }
        //public int BigBalcony { get; set; }
        //public int Refrigerator { get; set; }
        //public int FreeWifi { get; set; }
        //public int Hairdryer { get; set; }
        //public int PersonalBathroom { get; set; }

        //, DateTime checkIn, DateTime checkOut, int airConditioner,
        //              int plasmaTV, int bigBalcony, int refrigerator, int freeWIFI, int hairDryer, int personalBathroom
        public FilterType(int county, int city)
        {
            County = county;
            //City = city;
            //DateFrom = checkIn;
            //DateTill = checkOut;
            //AirConditioner = airConditioner;
            //PlasmaTV = plasmaTV;
            //BigBalcony = bigBalcony;
            //Refrigerator = refrigerator;
            //FreeWifi = freeWIFI;
            //Hairdryer = hairDryer;
            //PersonalBathroom = personalBathroom;
        }
        //is check box airconditioner is checked, then id = hardcodat(val din db)
    }
}
