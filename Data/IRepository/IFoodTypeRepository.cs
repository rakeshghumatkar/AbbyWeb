using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulkyBookWeb.Models;

namespace BulkyBookWeb.Data.IRepository
{
    public interface IFoodTypeRepository : IRepository<FoodType>
    
    {
        public void Update(FoodType foodType);
    }
}