using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BulkyBookWeb.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private BooksDbContext db;
        
        public UnitOfWork(BooksDbContext _db)
        {
            db = _db;
            Category =  new CategoryRepository(db);
            CoverType = new CoverTypeRepository(db);
        }
        public ICategoryRepository Category {get; private set;}

        public ICoverTypeRepository CoverType {get; private set;}

        public void Save()
        {
            db.SaveChanges();
        }
    }
}