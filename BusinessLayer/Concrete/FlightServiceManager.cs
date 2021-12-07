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
    public class FlightManager : IFlightService
    {
        IFlightDAL _flightDAL;

        public FlightManager(IFlightDAL flightDAL)
        {
            _flightDAL = flightDAL;
        }

        public void AddFlightService(Flight flight)
        {
            _flightDAL.Insert(flight);
        }
    }
}
