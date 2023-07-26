using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulkyBookWeb.Data.IRepository;

namespace BulkyBookWeb.Data.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category {get;}
        ICoverTypeRepository CoverType {get;}

        IFoodTypeRepository FoodType {get;}

        void Save();
        void SaveAsync();
    }
}