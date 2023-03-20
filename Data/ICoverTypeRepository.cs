using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulkyBookWeb.Models;

namespace BulkyBookWeb.Data
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        public void Update(CoverType obj);
    }
}