using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly BooksDbContext db;
        internal DbSet<T> dbSet ;
        public Repository(BooksDbContext _db)
        {
            db = _db;
            this.dbSet = _db.Set<T>() ;

        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> quary = dbSet;
            return quary.ToList();

        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> quary = dbSet;
            quary = quary.Where(filter);
            return quary.FirstOrDefault();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }
    }
}