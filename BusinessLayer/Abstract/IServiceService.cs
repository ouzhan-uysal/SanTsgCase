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
        void addHotelService(Hotel hotel);
        void addFlightService(Flight flight);
    }
}
