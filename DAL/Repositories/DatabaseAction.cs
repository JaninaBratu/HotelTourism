using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class DatabaseAction
    {

        public static void PopulateDatabase()
        {
            List<DateTime> rangePeriodList = GetPeriodVacation();

            using (var context = new ModelContext())
            {
                try
                {
                    User user = new User();
                    user.Username = "Janina";
                    user.Password = "pass01";
                    context.Users.Add(user);
                    context.SaveChanges();

                    County county = new County();
                    county.Name = "Brasov";
                    context.Counties.Add(county);
                    context.SaveChanges();

                    County county2 = new County();
                    county2.Name = "Maramures";
                    context.Counties.Add(county2);
                    context.SaveChanges();

                    City city = new City();
                    city.Name = "Rasnov";
                    city.County = context.Counties.FirstOrDefault(c => c.CountyId == 1);
                    context.Cities.Add(city);
                    context.SaveChanges();

                    City city2 = new City();
                    city2.Name = "Baia Mare";
                    city.County = context.Counties.FirstOrDefault(c => c.CountyId == 2);
                    context.Cities.Add(city2);
                    context.SaveChanges();

                    Hotel hotel = new Hotel();
                    hotel.Name = "Pensiunea Fermecata";
                    hotel.City = context.Cities.FirstOrDefault(c=>c.CityId == 1);
                    context.Hotels.Add(hotel);

                    Hotel hotel2 = new Hotel();
                    hotel2.Name = "Norocul plutitor";
                    hotel2.City = context.Cities.FirstOrDefault(c => c.CityId == 2);
                    context.Hotels.Add(hotel2);
                    context.SaveChanges();

                    RoomType singleRoomType = new RoomType();
                    singleRoomType.Name = "Single";
                    context.RoomTypes.Add(singleRoomType);
                    context.SaveChanges();

                    RoomType doubleRoomType = new RoomType();
                    doubleRoomType.Name = "Double";
                    context.RoomTypes.Add(doubleRoomType);
                    context.SaveChanges();

                    Facility facility = new Facility();
                    facility.Name = "Air conditioner";
                    context.Facilities.Add(facility);
                    context.SaveChanges();

                    Facility facility2 = new Facility();
                    facility2.Name = "Plasma TV";
                    context.Facilities.Add(facility2);
                    context.SaveChanges();

                    Facility facility3 = new Facility();
                    facility3.Name = "Big Balcony";
                    context.Facilities.Add(facility3);
                    context.SaveChanges();

                    Facility facility4 = new Facility();
                    facility4.Name = "Refrigerator";
                    context.Facilities.Add(facility4);
                    context.SaveChanges();

                    Room room = new Room();
                    room.Price = 180;
                    room.Hotel = context.Hotels.FirstOrDefault(h=>h.HotelId == 1);
                    room.RoomType = context.RoomTypes.FirstOrDefault(rt=>rt.RoomTypeId == 1);
                    context.Rooms.Add(room);
                    context.SaveChanges();

                    Room room2 = new Room();
                    room2.Price = 300;
                    room2.Hotel = context.Hotels.FirstOrDefault(h => h.HotelId == 2);
                    room2.RoomType = context.RoomTypes.FirstOrDefault(rt => rt.RoomTypeId == 2);
                    context.Rooms.Add(room2);
                    context.SaveChanges();

                    Rezervation rezervation = new Rezervation();
                    rezervation.User = context.Users.FirstOrDefault(u => u.UserId == 1);
                    rezervation.CheckIn = rangePeriodList[0];
                    rezervation.CheckOut = rangePeriodList[1];
                    context.Rezervations.Add(rezervation);
                    context.SaveChanges();

                    var rezerv = new Rezervation(){CheckIn = rangePeriodList[0], CheckOut = rangePeriodList[1]};
                    var specialRoom = new Room() { Price = 245};
                    RezervationRoom rezervRoom = new RezervationRoom();
                    rezervRoom.Rezervation = rezerv;
                    rezervRoom.Room = room;
                    context.RezervationRooms.Add(rezervRoom);
                    context.SaveChanges();

                    FacilityRoom facilRoom = new FacilityRoom();
                    facilRoom.Facility = context.Facilities.FirstOrDefault(f=>f.FacilityId == 1);
                    facilRoom.Room = context.Rooms.FirstOrDefault(r=>r.RoomId==1);
                    context.FacilityRooms.Add(facilRoom);
                    context.SaveChanges();

                }
                catch (Exception)
                {

                    throw;
                }
            }
            
        }

        public static List<DateTime> GetPeriodVacation()
        {
            DateTime checkInDate = new DateTime();
            DateTime checkOutDate = new DateTime();

            List<DateTime> rangePeriodList = new List<DateTime>();

            string val1 = "11/30/2016 12:00:00 AM";
            string val2 = "12/07/2016 11:00:00 AM";

            checkInDate = DateTime.Parse(val1);
            checkOutDate = DateTime.Parse(val2);
            rangePeriodList.Add(checkInDate);
            rangePeriodList.Add(checkOutDate);

            return rangePeriodList;
        }
    }
}
