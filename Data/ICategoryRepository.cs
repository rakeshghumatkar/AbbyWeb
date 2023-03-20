using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulkyBookWeb.Models;

namespace BulkyBookWeb.Data
{
    public interface ICategoryRepository : IRepository<Category>
    {
        // public void Save();
        public void Update(Category obj);
    }
}