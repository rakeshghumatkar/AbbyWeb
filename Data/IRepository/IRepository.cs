using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BulkyBookWeb.Data.IRepository
{
    public interface IRepository<T> where T : class //where T : This is use to define that
    // it only refer by class basically reference type and prohabited value type i.e. int, string, etc.
    {
        IEnumerable<T> GetAll();

        T GetFirstOrDefault(Expression<Func<T, bool>> filter); //Expression is refer the (x=>x.id==id) to execute the give expression .
        
        void Add(T entity);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entity);
        
    }
}