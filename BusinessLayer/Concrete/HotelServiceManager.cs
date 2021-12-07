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
    public class HotelManager : IHotelService
    {
        IHotelDAL _hotelDAL;

        public HotelManager(IHotelDAL hotelDAL)
        {
            _hotelDAL = hotelDAL;
        }

        public void addHotelService(Hotel hotel)
        {
            _hotelDAL.Insert(hotel);
        }
    }
}
