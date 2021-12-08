using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        ILocationDAL _locationDAL;
        IHotelDAL _hotelDAL;
        IFlightDAL _flightDAL;

        public ServiceManager(ILocationDAL locationDAL) => _locationDAL = locationDAL;
        public ServiceManager(IHotelDAL hotelDAL) => _hotelDAL = hotelDAL;
        public ServiceManager(IFlightDAL flightDAL) => _flightDAL = flightDAL;

        public void AddFlight(Flight flight) => _flightDAL.Insert(flight);

        public void AddHotel(Hotel hotel) => _hotelDAL.Insert(hotel);

        public Location GetLocationByID(int id)
        {
            return _locationDAL.GetById(id);
        }

        public List<Hotel> GetHotelList()
        {
            return _hotelDAL.GetListAll();
        }

        public List<Flight> GetFlightList()
        {
            return _flightDAL.GetListAll();
        }

        public List<Location> GetLocationList()
        {
            return _locationDAL.GetListAll();
        }
    }
}
