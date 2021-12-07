using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class LocationManager : ILocationService
    {
        //EFLocationRepository lr;
        ILocationDAL _locationDAL;
        public LocationManager(ILocationDAL locationDAL)
        {
            _locationDAL = locationDAL;
        }

        public void AddLocation(Location location)
        {
            _locationDAL.Insert(location);
        }

        public void DeleteLocation(Location location)
        {
            _locationDAL.Delete(location);
        }

        public List<Location> GetList()
        {
            return _locationDAL.GetListAll();
        }

        public Location GetLocationByID(int id)
        {
            return _locationDAL.GetById(id);
        }

        public void UpdateLocation(Location location)
        {
            _locationDAL.Update(location);
        }
    }
}
