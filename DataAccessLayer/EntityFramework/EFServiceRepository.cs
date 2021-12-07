using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFServiceRepository : GenericRepository<Hotel, Flight>, IServiceDAL
    {
        public void Delete(Hotel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Flight entity)
        {
            throw new NotImplementedException();
        }

        public Hotel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Hotel> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Hotel entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(Flight entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Hotel entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Flight entity)
        {
            throw new NotImplementedException();
        }

        Flight IGenericDAL<Flight>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        List<Flight> IGenericDAL<Flight>.GetListAll()
        {
            throw new NotImplementedException();
        }
    }
}
