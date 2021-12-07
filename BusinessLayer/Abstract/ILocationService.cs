using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ILocationService
    {
        void AddLocation(Location location);
        List<Location> GetList();
        Location GetLocationByID(int id);
    }
}
