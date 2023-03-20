using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BulkyBookWeb.Data
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category {get;}
        ICoverTypeRepository CoverType {get;}

        void Save();
    }
}