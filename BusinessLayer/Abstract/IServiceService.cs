using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IServiceService
    {
        void AddHotel(Hotel hotel);
        void AddFlight(Flight flight);
        List<Hotel> GetHotelList();
        List<Flight> GetFlightList();
        List<Location> GetLocationList();
        Location GetLocationByID(int id);
    }
}
