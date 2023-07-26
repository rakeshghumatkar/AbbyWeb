using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulkyBookWeb.Data.IRepository;
using BulkyBookWeb.Models;

namespace BulkyBookWeb.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private BooksDbContext db;
        public ICategoryRepository Category {get; private set;}
        public ICoverTypeRepository CoverType {get; private set;}
        public IFoodTypeRepository FoodType {get; private set;}

        public UnitOfWork(BooksDbContext _db)
        {
            db = _db;
            Category =  new CategoryRepository(db);
            CoverType = new CoverTypeRepository(db);
            FoodType = new FoodTypeRepository(db);
        }
        

        public void Save()
        {
            db.SaveChanges();
        }
        public void SaveAsync()
        {
            db.SaveChangesAsync();
        }

    }
}