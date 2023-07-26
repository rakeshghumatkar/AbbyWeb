using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulkyBookWeb.Data.IRepository;
using BulkyBookWeb.Models;

namespace BulkyBookWeb.Data
{
    public class FoodTypeRepository : Repository<FoodType>, IFoodTypeRepository
    {
        private readonly BooksDbContext db;
        public FoodTypeRepository(BooksDbContext _db) : base(_db)
        {
            db = _db;
        }

        public void Update(FoodType foodType)
        {
            FoodType ft = db.foodTypes.FirstOrDefault(x=>x.Id == foodType.Id);
            ft.Name = foodType.Name;
            db.foodTypes.Update(ft);
        }
    }
}