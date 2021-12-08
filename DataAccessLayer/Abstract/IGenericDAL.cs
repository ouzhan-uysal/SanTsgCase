using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> where T : class // Bir classa ait tüm değerleri kullanacak
    {
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
        List<T> GetListAll();
        T GetById(int id);  // id ye göre getir
        List<T> List(Expression<Func<T, bool>> filter);    // Expression: şartlı sorgulamalar için
    }
    public interface IGenericDAL<T1, T2> where T1 : class where T2 : class
    {
        void Insert(T1 entity1, T2 entity2);
    }
}
