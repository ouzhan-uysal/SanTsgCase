using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        public void Delete(T entity)
        {
            using var c = new Context();
            c.Remove(entity);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find();
        }

        public List<T> GetListAll()
        {
            using var c = new Context();
            return c.Set<T>().ToList(); // Set'teki T değişkenine bağlı
        }

        public void Insert(T entity)
        {
            using var c = new Context();
            c.Add(entity);
            c.SaveChanges();
        }

        public void Update(T entity)
        {
            using var c = new Context();
            c.Update(entity);
            c.SaveChanges();
        }
    }
    public class GenericRepository<T1, T2> : IGenericDAL<T1, T2> where T1 : class where T2 : class
    {
        public void Insert(T1 entity1, T2 entity2)
        {
            if (entity1 != null)
            {
                using var c = new Context();
                c.Update(entity1);
                c.SaveChanges();
            } else if (entity2 != null)
            {
                using var c = new Context();
                c.Update(entity2);
                c.SaveChanges();
            } else
            {

            }
        }
    }
}
