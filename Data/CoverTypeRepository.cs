using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulkyBookWeb.Models;

namespace BulkyBookWeb.Data
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private BooksDbContext db ;

        public CoverTypeRepository(BooksDbContext _db) : base(_db)
        {
            db = _db;
        }
        public void Update(CoverType obj)
        {
            db.Update(obj);
        }
    }
}