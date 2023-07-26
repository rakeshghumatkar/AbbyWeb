using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulkyBookWeb.Models;

namespace BulkyBookWeb.Data.IRepository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly BooksDbContext db;
        public CategoryRepository(BooksDbContext _db) : base(_db)
        {
            db = _db;
        }
        // public void Save()
        // {
        //     db.SaveChanges();
        // }

        public void Update(Category obj)
        {
            db.categories.Update(obj);
        }
    }
}